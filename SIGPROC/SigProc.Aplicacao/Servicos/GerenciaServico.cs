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

        public object Atualizar(GerenciaUpdateModelo gerenciaUpdate)
        {
            Gerencia gerenciaExistente = gerenciaDomainService.ObterPorId(gerenciaUpdate.Sigla) ;

            if (gerenciaExistente == null)
            {
                throw new Exception("Gerencia não encontrada.");
            }

            gerenciaExistente.Descricao = gerenciaUpdate.Descricao;
            gerenciaExistente.Sigla = gerenciaUpdate.Sigla;
            gerenciaExistente.Prazo = gerenciaUpdate.Prazo;
            gerenciaExistente.Email = gerenciaUpdate.Email;
            gerenciaExistente.Telefone = gerenciaUpdate.Telefone;

            gerenciaDomainService.Atualizar(gerenciaExistente);

            return new { Sucesso = true, Mensagem = "Gerencia atualizada com sucesso." };
        }



        public ICollection<Gerencia> ListarAtivos()
        {
            return gerenciaDomainService.ListarAtivos();
        }
    }

}
