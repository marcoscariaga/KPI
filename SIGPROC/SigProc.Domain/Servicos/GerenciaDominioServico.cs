using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Infra.Seguranca.Servico;

namespace SigProc.Dominio.Servicos
{

    public class GerenciaDominioServico : BaseDominioServico<Gerencia>, IGerenciaDominioServico
    {
        private readonly IGerenciaRepositorio _repositorio;
        private readonly IGerenciaPrazoDominioServico _repositorioPrazo;
        public GerenciaDominioServico(IGerenciaRepositorio repository, IGerenciaPrazoDominioServico repositorioPrazo) : base(repository)
        {
            _repositorio = repository;
            _repositorioPrazo = repositorioPrazo;
        }

        public ICollection<Gerencia> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public Gerencia Inserir(Gerencia objeto)
        {
            if (objeto.Prazo <= 0)
                throw new ArgumentException("Informe o prazo da gerência!" );

            #region Cadastro da Gerência
            var gerencia = _repositorio.Inserir(objeto);
            #endregion

            #region Cadastro do prazo da Gerência
            GerenciaPrazo prazo = new GerenciaPrazo()
            {
                IdGerencia = gerencia.Id,
                IdTipoPrazo = 1,
                Prazo = objeto.Prazo,
                IdUsuarioCadastro = objeto.IdUsuarioResp,
                Status = true
            };
            _repositorioPrazo.Inserir(prazo);
            #endregion

            return gerencia;
        }

    }
}
