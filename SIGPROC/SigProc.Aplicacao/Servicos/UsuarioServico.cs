using SigProc.Aplicacao.Contratos;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Infra.Seguranca.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class UsuarioServico : BaseServico<Usuario>, IUsuarioServico
    {
        private readonly IUsuarioDominioServico usuarioDomainService;
        private readonly TokenServico tokenService;
        public UsuarioServico(IUsuarioDominioServico usuarioDomainService, TokenServico tokenService) : base(usuarioDomainService)
        {
            this.usuarioDomainService = usuarioDomainService;
            this.tokenService = tokenService;
        }
        public Usuario BuscarPorCpf(string cpf)
            => usuarioDomainService.BuscarPorCpf(cpf);

        public Usuario BuscarPorEmail(string email)
            => usuarioDomainService.BuscarPorEmail(email);

        public Usuario Get(string email, string senha)
            => usuarioDomainService.Get(email, senha);
        public string GetAccessToken(Usuario usuario)
        {
            var verifica = usuarioDomainService.Get(usuario.Email, usuario.Senha);
            if (verifica == null)
            {
                throw new Exception("Acesso Negado. Usuário não encontrado");
            }
            return tokenService.GenerateToken(usuario.Email);
        }
    }
}
