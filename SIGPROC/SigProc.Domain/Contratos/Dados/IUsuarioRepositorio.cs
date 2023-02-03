using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domain.Contratos.Dados
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario BuscarPorEmail(string email);
        Usuario BuscarPorCpf(string cpf);
        Usuario Get(string email, string senha);
    }
}
