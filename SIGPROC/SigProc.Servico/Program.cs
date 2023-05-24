using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using SigProc.Aplicacao.Servicos;
using SigProc.Servico.Configuracao;
using SigProc.Servico.Configurar;
using System.Collections.ObjectModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

AplicacaoConfig.AddApplicationConfig(builder);
DominioConfig.AddDomainConfig(builder);
RepositorioConfig.AddRepositoryConfig(builder);
AutenticacaoConfig.AddAuthenticationSetup(builder);
builder.Services.AddControllers();

var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

Log.Logger = new LoggerConfiguration()
       .Enrich.FromLogContext()
                .Enrich.FromLogContext()
                .WriteTo.MSSqlServer(
                    connectionString: configuration.GetConnectionString("SIGPROC"),
                    tableName: "Logs"
                )
                .CreateLogger();


builder.Services.AddControllers();
builder.Services.AddHostedService<RotinaPrazoService>();
builder.Services.AddHostedService<RotinaTramitacaoHostedServico>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
SwaggerConfig.AddSwaggerSetup(builder);
CorsConfig.AddCorsSetup(builder);

var app = builder.Build();

SwaggerConfig.UseSwaggerSetup(app);
CorsConfig.UseCorsSetup(app);

app.UseAuthorization();
app.UseAuthorization();


app.MapControllers();

app.Run();
