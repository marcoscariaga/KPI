using SigProc.Aplicacao.Modelos;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Contratos
{
    public interface IGerenciaServico : IBaseDominioServico<Gerencia>
    {
        //Gerencia Atualizar(GerenciaUpdateModelo gerenciaUpdate);
        ICollection<Gerencia> ListarAtivos();
        //public ICollection<Gerencia> ListarAtivos();
    }
}
