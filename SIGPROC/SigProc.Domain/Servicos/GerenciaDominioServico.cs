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
        private readonly IGerenciaUsuarioDominioServico _repositorioGerenciaUsuario;
        private readonly ITipoUsuarioGerenciaDominioServico _repositorioTipoUsuaruiGerencia;

        public GerenciaDominioServico(IGerenciaRepositorio repository, IGerenciaPrazoDominioServico repositorioPrazo, IGerenciaUsuarioDominioServico repositorioGerenciaUsuario, ITipoUsuarioGerenciaDominioServico repositorioTipoUsuaruiGerencia) : base(repository)
        {
            _repositorio = repository;
            _repositorioPrazo = repositorioPrazo;
            _repositorioGerenciaUsuario = repositorioGerenciaUsuario;
            _repositorioTipoUsuaruiGerencia = repositorioTipoUsuaruiGerencia;
        }

        public ICollection<Gerencia> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public Gerencia Inserir(Gerencia objeto)
        {
            if (objeto.Prazo <= 0)
                throw new ArgumentException("Informe o prazo da gerência!");

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

            #region Associação entre a gerencia e usuário
            var tipoUsuario = _repositorioTipoUsuaruiGerencia.ListarAtivos().Where(x=>x.Descricao.ToLower().Equals("gerente")).FirstOrDefault();

            GerenciaUsuario usuario = new GerenciaUsuario()
            {
                IdGerencia = gerencia.Id,
                IdUsuarioGerencia = objeto.IdUsuarioResp,
                IdTipoUsuarioGerencia = tipoUsuario.Id,
                IdUsuarioCadastro = objeto.IdUsuarioResp,
            };
            #endregion

            return gerencia;
        }

    }
}
