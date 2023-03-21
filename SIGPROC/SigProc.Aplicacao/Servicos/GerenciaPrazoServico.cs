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
    public class GerenciaPrazoServico : BaseServico<GerenciaPrazo>, IGerenciaPrazoServico
    {
        private readonly IGerenciaPrazoDominioServico gerenciaPrazoDomainService;
        public GerenciaPrazoServico(IGerenciaPrazoDominioServico gerenciaPrazoDomainService) : base(gerenciaPrazoDomainService)
        {
            this.gerenciaPrazoDomainService = gerenciaPrazoDomainService;
        }

        public ICollection<GerenciaPrazo> ListarAtivos()
        {
            return gerenciaPrazoDomainService.ListarAtivos();
        }
        public ICollection<GerenciaPrazo> RetornaPorIdGerencia(int id_gerencia)
        {
            return gerenciaPrazoDomainService.RetornaPorIdGerencia(id_gerencia);
        }

    }

}
