namespace KPI.Configurations
{
    public class SqlServerConfiguration
    {
        public static string GetConnectionString()
        {
            //Production
            //return @"Data Source=clustersql2.rio.rj.gov.br;Initial Catalog=SISVISA;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            //Stagging
            return @"Data Source=srv000107\hom;Initial Catalog=SISVISA;User ID=user_sisvisa;Password=va0wek0HieGaoJu;Integrated Security=False;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
    }
}