using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Contratos
{
    public interface IUsuarioServico : IBaseDominioServico<Usuario>
    {
        string GetAccessToken(Usuario usuario);
        public Usuario Get(string email, string senha);
        Usuario BuscarPorEmail(string email);
        Usuario BuscarPorCpf(string cpf);
    }
}
