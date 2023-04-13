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
            GerenciaPrazo prazo = new GerenciaPrazo();
            #region Cadastro do prazo da Gerência
            try
            {
                prazo.IdGerencia = gerencia.Id;
                prazo.IdTipoPrazo = 1;
                prazo.Prazo = objeto.Prazo;
                prazo.IdUsuarioCadastro = objeto.IdUsuarioResp;
                prazo.Status = true;

                _repositorioPrazo.Inserir(prazo);
            }

            catch (Exception)
            {
                _repositorio.Deletar(gerencia);
            }

            #endregion

            #region Associação entre a gerencia e usuário
            try
            {
                var tipoUsuario = _repositorioTipoUsuaruiGerencia.ListarAtivos().Where(x => x.Descricao.ToLower().Equals("gerente")).FirstOrDefault();

                GerenciaUsuario usuario = new GerenciaUsuario()
                {
                    IdGerencia = gerencia.Id,
                    IdUsuarioGerencia = objeto.IdUsuarioResp,
                    IdTipoUsuarioGerencia = tipoUsuario.Id,
                    IdUsuarioCadastro = objeto.IdUsuarioResp,
                    Status = true,
            };
                #endregion
                _repositorioGerenciaUsuario.Inserir(usuario);
                return gerencia;
            }

            catch (Exception)
            {
                _repositorio.Deletar(gerencia);
                _repositorioPrazo.Deletar(prazo);
            }
            return gerencia;
        }

    }
}
