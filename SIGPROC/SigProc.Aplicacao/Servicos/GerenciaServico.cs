using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class GerenciaServico : BaseServico<Gerencia>, IGerenciaServico
    {
        private readonly IGerenciaDominioServico gerenciaDomainService;
        public GerenciaServico(IGerenciaDominioServico gerenciaDomainService) : base(gerenciaDomainService)
        {
            this.gerenciaDomainService = gerenciaDomainService;
        }

        //public Gerencia Atualizar(GerenciaUpdateModelo gerenciaUpdate)
        //{
        //    var gerenciaExistente = gerenciaDomainService.RetornaPorId(gerenciaUpdate.Id);
        //    if (gerenciaExistente == null)
        //    {
        //        throw new ArgumentException("Gerência não encontrada");
        //    }

        //    gerenciaExistente.Sigla = gerenciaUpdate.Sigla;
        //    gerenciaExistente.Descricao = gerenciaUpdate.Descricao;
        //    gerenciaExistente.Email = gerenciaUpdate.Email;
        //    gerenciaExistente.Prazo = gerenciaUpdate.Prazo;
        //    gerenciaExistente.Status = gerenciaUpdate.Status;
        //    gerenciaExistente.Telefone = gerenciaUpdate.Telefone;

        //    gerenciaDomainService.Atualizar(gerenciaExistente);

        //    return gerenciaExistente;
        //}




        public ICollection<Gerencia> ListarAtivos()
        {
            return gerenciaDomainService.ListarAtivos();
        }


    }

}
