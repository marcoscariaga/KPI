using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domain.Contratos.Servicos
{
    public interface IUsuarioDominioServico : IBaseDominioServico<Usuario>
    {
        Usuario BuscarPorEmail(string email);
        Usuario BuscarPorCpf(string cpf);
        Usuario Get(string email, string senha);
    }
}
