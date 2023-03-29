using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ServiceSicop;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoDominioServico : BaseDominioServico<Processo>, IProcessoDominioServico
    {
        private readonly IProcessoRepositorio _repositorio;
        private readonly IGerenciaRepositorio _gerencia;
        private readonly IProcessoTramitacaoRepositorio _processoTramitacao;
        private readonly IGerenciaPrazoRepositorio _gerenciaPrazo;
        public ProcessoDominioServico(IProcessoRepositorio repository, IGerenciaRepositorio gerencia, IProcessoTramitacaoRepositorio processoTramitacao, IGerenciaPrazoRepositorio gerenciaPrazo) : base(repository)
        {
            _repositorio = repository;
            _gerencia = gerencia;
            _processoTramitacao = processoTramitacao;
            _gerenciaPrazo = gerenciaPrazo;
        }

        public ICollection<Processo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public Processo Inserir(Processo processo)
        {
            var consultaProcesso = _repositorio.BuscarPorNumeroProcesso(processo.NumProcesso);
            if (consultaProcesso != null)
                throw new ArgumentException($"O processo {processo.NumProcesso} já está cadastrado no sistema.");

            string[] siglaDestino = processo.OrgaoDestino.Split('-');
            string[] siglaOrigem = processo.OrgaoOrigem.Split('-');

            var orgaoDestino = _gerencia.BuscarPorSiglaGerencia(siglaDestino[1].Trim());
            if (orgaoDestino == null)
                throw new ArgumentException($"A gerência {siglaDestino}, não está cadastrada no sistema.");

            var orgaoOrigem = _gerencia.BuscarPorSiglaGerencia(siglaOrigem[1].Trim());
            if (orgaoOrigem == null)
                throw new ArgumentException($"A gerência {orgaoOrigem}, não está cadastrada no sistema.");

            var cadProcesso = _repositorio.Inserir(processo);
            //var cadProcesso = new Processo();
           
            try
            {
                var prazo = _gerenciaPrazo.ListarTudo().Where(x=>x.IdGerencia.Equals(orgaoDestino.Id)).OrderByDescending(x=>x.Prazo).FirstOrDefault();

            DateTime dataAtual = DateTime.Now;
            int diasParaAcrescentar = prazo.Prazo;

            DateTime dataFutura = dataAtual;
            int diasAcrescentados = 0;
            while (diasAcrescentados < diasParaAcrescentar)
            {
                dataFutura = dataFutura.AddDays(1);
                if (dataFutura.DayOfWeek != DayOfWeek.Saturday && dataFutura.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasAcrescentados++;
                }
            }

            ProcessoTramitacao processoTramitacao = new ProcessoTramitacao()
            {
                IdProcesso = cadProcesso.Id,
                IdOrgaoOrigem = orgaoOrigem.Id,
                IdOrgaoDestino = orgaoDestino.Id,
                Prazo = diasAcrescentados,
                DataTramitacao = DateTime.Now,
                DataPrazo = dataFutura,
                Observacao = processo.Observacao,
                IdUsuarioTramitacao = processo.IdUsuarioCadastro,
                Status = true,
                NumeroProcesso = processo.NumProcesso
            };

         
                _processoTramitacao.Inserir(processoTramitacao);
            }
            catch (Exception)
            {

                _repositorio.Deletar(processo);
                throw new ArgumentException($"Erro ao cadastrar a tramitação, tente novamente.");
            }
           

            return cadProcesso;
        }
    }
}
