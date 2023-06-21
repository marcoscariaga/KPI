using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Serilog;
using ServiceSicop;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoDominioServico : BaseDominioServico<Processo>, IProcessoDominioServico
    {
        private readonly IProcessoRepositorio _repositorio;
        private readonly IProcessoTramitacaoDominioServico _processoTramitacao;

        public ProcessoDominioServico(IProcessoRepositorio repository, IProcessoTramitacaoDominioServico processoTramitacao) : base(repository)
        {
            _repositorio = repository;
            _processoTramitacao = processoTramitacao;
        }

        public ICollection<Processo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public Processo Inserir(Processo processo)
        {
            #region Validação para cadastrar o processo
            processo.IdStatusProcesso = 1;
            var consultaProcesso = _repositorio.BuscarPorNumeroProcesso(processo.NumProcesso);
            if (consultaProcesso != null)
                throw new ArgumentException($"O processo {processo.NumProcesso} já está cadastrado no sistema.");

            var cadProcesso = _repositorio.Inserir(processo);

            #endregion

            try
            {
                ProcessoTramitacao processoTramitacao = new ProcessoTramitacao()
                {
                    IdProcesso = cadProcesso.Id,
                    Status = true,
                    NumeroProcesso = processo.NumProcesso,
                };
            
                _processoTramitacao.Inserir(processoTramitacao);
            }
            catch (Exception ex)
            {
                _repositorio.Deletar(processo);
                Log.ForContext("Acao", $"InserirProcesso").Warning($"Erro ao cadastrar a tramitação, tente novamente.{ex.Message}");
                throw new ArgumentException($"Erro ao cadastrar a tramitação, tente novamente.");
            }


            return cadProcesso;
        }
        
    }
}
