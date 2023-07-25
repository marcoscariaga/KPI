using SigProc.Aplicacao.Contratos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class GerenciaUsuarioServico : BaseServico<GerenciaUsuario>, IGerenciaUsuarioServico
    {
        private readonly IGerenciaUsuarioDominioServico gerenciaUsuarioDomainService;
        public GerenciaUsuarioServico(IGerenciaUsuarioDominioServico gerenciaUsuarioDomainService) : base(gerenciaUsuarioDomainService)
        {
            this.gerenciaUsuarioDomainService = gerenciaUsuarioDomainService;
        }

        public ICollection<GerenciaUsuario> ListarAtivos()
        {
            return gerenciaUsuarioDomainService.ListarAtivos();
        }

        public ICollection<GerenciaUsuario> ListarGerenciaPorIdUsuario(int idUsuario)
        {
            return gerenciaUsuarioDomainService.ListarGerenciaPorIdUsuario(idUsuario);
        }

        public ICollection<GerenciaUsuario> RetornaPorIdGerencia(int id_gerencia)
        {
            return gerenciaUsuarioDomainService.RetornaPorIdGerencia(id_gerencia);
        }

    }

}
