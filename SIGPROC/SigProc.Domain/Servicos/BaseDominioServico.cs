using SigProc.Domain.Contratos.Dados;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Infra.Seguranca.Servico;

namespace SigProc.Dominio.Servicos
{
    public abstract class BaseDominioServico<TEntity> : IBaseDominioServico<TEntity> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> repository;
        protected BaseDominioServico(IBaseRepositorio<TEntity> repository)
        {
            this.repository = repository;
        }

        public TEntity Atualizar(TEntity objeto)
        {
            return repository.Atualizar(objeto);
        }

        public TEntity Deletar(TEntity objeto)
        {
            return repository.Deletar(objeto);
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public TEntity Inserir(TEntity objeto)
        {
            return repository.Inserir(objeto);
        }

        public ICollection<TEntity> ListarTudo()
        {
            return repository.ListarTudo();
        }

        public TEntity RetornaPorId(int id)
        {
            return repository.RetornaPorId(id);
        }

        TEntity IBaseDominioServico<TEntity>.Excluir(int id)
        {
            return repository.Excluir(id);
        }
    }
}
