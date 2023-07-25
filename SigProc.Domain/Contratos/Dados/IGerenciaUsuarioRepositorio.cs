using SigProc.Domain.Contratos.Dados;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Contratos.Dados
{
    public interface IGerenciaUsuarioRepositorio : IBaseRepositorio<GerenciaUsuario>
    {
        ICollection<GerenciaUsuario> ListarAtivos();
        ICollection<GerenciaUsuario> RetornaPorIdGerencia(int id_gerencia);
        public ICollection<GerenciaUsuario> ListarGerenciaPorIdUsuario(int idUsuario);
    }
}
