using Microsoft.EntityFrameworkCore;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class FeriadoRepositorio : BaseRepositorio<Feriado>, IFeriadoRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public FeriadoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<DateTime> ListarDatas()
        {
            // Cria uma lista para armazenar as datas dos feriados
            List<DateTime> datasFeriados = new List<DateTime>();

            // Faz a busca dos feriados e seleciona somente o campo "DataFeriado"
            var feriados = contexto.Feriado.Where(x => x.Status == true).Select(f => f.DataFeriado);

            // Adiciona as datas dos feriados à lista de datasFeriados
            datasFeriados.AddRange(feriados);

            // Imprime as datas dos feriados na lista
            foreach (DateTime dataFeriado in datasFeriados)
            {
                Console.WriteLine(dataFeriado.ToString("dd/MM/yyyy"));
            }

            return datasFeriados;
        }
    }
}
