using Microsoft.IdentityModel.Tokens;
using SigProc.Infra.Seguranca.Contexto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Infra.Seguranca.Servico
{
    public class TokenServico
    {
        private readonly AppConfig appSettings;
        public TokenServico(AppConfig appSettings)
        {
            this.appSettings = appSettings;
        }
        public string GenerateToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(appSettings.SecurityKey);

            var tokenDescription = new SecurityTokenDescriptor
            {
                //criando a identificação do usuario para o AspNet
                Subject = new ClaimsIdentity(new Claim[]
             {
                new Claim(ClaimTypes.Name, username) //nome do usuario
             }),
                //definindo a data de expiração do Token
                Expires = DateTime.UtcNow.AddHours(12),
                //criptografia do Token a chave secreta (evitar falsificação)
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
             SecurityAlgorithms.HmacSha256Signature)
            };
            //retornando o TOKEN
            var token = tokenHandler.CreateToken(tokenDescription);
            return tokenHandler.WriteToken(token);
        }
    }
}
