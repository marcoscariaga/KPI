using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Contratos.Dados;
using SigProc.Domain.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.Infra.Seguranca.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public UsuarioRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public Usuario BuscarPorCpf(string cpf)
            => contexto.Usuario
                .AsNoTracking()
                .FirstOrDefault(x => x.Cpf.Equals(cpf));

        public Usuario BuscarPorEmail(string email)
            => contexto.Usuario
                .AsNoTracking()
                .FirstOrDefault(x => x.Email.Equals(email));

        public Usuario Get(string email, string senha)
        {
            senha = CriptografiaServico.Encrypt(senha);
            var usuario = contexto.Usuario.FirstOrDefault(c => c.Email.Equals(email) && c.Senha.Equals(senha));

            return usuario;
        }
    }
}
