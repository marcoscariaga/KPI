namespace KPI.Configurations
{
    public class SqlServerConfiguration
    {
        public static string GetConnectionString()
        {
            return @"Data Source=clustersql2.rio.rj.gov.br;Initial Catalog=SISVISA;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
    }
}