using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class GerenciaPrazoDominioServico : BaseDominioServico<GerenciaPrazo>, IGerenciaPrazoDominioServico
    {
        private readonly IGerenciaPrazoRepositorio _repositorio;
        public GerenciaPrazoDominioServico(IGerenciaPrazoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<GerenciaPrazo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }

        public ICollection<GerenciaPrazo> RetornaPorIdGerencia(int id_gerencia)
        {
            return _repositorio.RetornaPorIdGerencia(id_gerencia);
        }
    }
}
