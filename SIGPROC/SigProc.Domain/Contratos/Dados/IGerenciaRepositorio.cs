using SigProc.Domain.Contratos.Dados;
using SigProc.Domain.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Contratos.Dados
{
    public interface IGerenciaRepositorio : IBaseRepositorio<Gerencia>
    {
        ICollection<Gerencia> ListarAtivos();
        Gerencia BuscarPorSiglaGerencia(string sigla);
    }
}
