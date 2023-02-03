using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domain.Contratos.Servicos
{
    public interface IBaseDominioServico<TEntity> : IDisposable where TEntity : class
    {
        TEntity Inserir(TEntity objeto);
        TEntity Atualizar(TEntity objeto);
        TEntity Excluir(int id);
        ICollection<TEntity> ListarTudo();
        TEntity RetornaPorId(int id);
    }
}
