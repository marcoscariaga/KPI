using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Contratos
{
    //Alterar o nome da classe para ITipoModalidadeServico
    public interface ITipoContratacaoServico : IBaseDominioServico<TipoContratacao>
    {
        public ICollection<TipoContratacao> ListarAtivos();
    }
}
