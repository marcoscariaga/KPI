using SigProc.Aplicacao.Servicos;
using SigProc.Servico.Configuracao;
using SigProc.Servico.Configurar;

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
