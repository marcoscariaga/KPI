using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Contextos
{
    public class SqlServidorContextoMigracao : IDesignTimeDbContextFactory<SqlServidorContexto>
    {
        public SqlServidorContexto CreateDbContext(string[] args)
        {
            #region Ler a connectionstring mapeada no appsettings.json
            var builder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            builder.AddJsonFile(path);
            var root = builder.Build();
            var connectionString = root.GetSection("ConnectionStrings")
            .GetSection("SIGPROC").Value;
            #endregion

            #region Configurando o Migrations
            var options = new DbContextOptionsBuilder<SqlServidorContexto>();
            options.UseSqlServer(connectionString);
            return new SqlServidorContexto(options.Options);
            #endregion
        }
    }
}
