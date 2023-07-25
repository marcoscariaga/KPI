using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Mapeamentos
{
    public class DadosDeTramitacaoSicopMap : IEntityTypeConfiguration<DadosDeTramitacaoSicop>
    {
        public void Configure(EntityTypeBuilder<DadosDeTramitacaoSicop> builder)
        {
           
        }
    }
}
