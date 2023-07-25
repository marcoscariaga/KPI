using SigProc.Domain.Contratos.Dados;
using SigProc.Domain.Contratos.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class BaseServico<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly IBaseDominioServico<TEntity> _servico;

        public BaseServico(IBaseDominioServico<TEntity> servico)
        {
            _servico = servico;
        }
        public TEntity Atualizar(TEntity objeto)
        {
            return _servico.Atualizar(objeto);
        }

        public TEntity Deletar(TEntity objeto)
        {
            return _servico.Deletar(objeto);
        }

        public void Dispose()
        {
            _servico.Dispose();
        }

        public TEntity Excluir(int id)
        {
            return _servico.Excluir(id);
        }

        public TEntity Inserir(TEntity objeto)
        {
            return _servico.Inserir(objeto);
        }

        public ICollection<TEntity> ListarTudo()
        {
            return _servico.ListarTudo();
        }

        public TEntity RetornaPorId(int id)
        {
            return _servico.RetornaPorId(id);
        }
    }
}
