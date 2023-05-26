using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using SigProc.Dominio.Contratos.Dados;

namespace SigProc.Aplicacao.Servicos
{
    public class RotinaPrazoService : IHostedService, IDisposable
    {
        private Timer _timer;

        public IServiceProvider ServiceProvider { get; set; }

        public RotinaPrazoService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            var horarios = new List<TimeSpan>
            {
                new TimeSpan(02, 30, 0), // 02:00
                new TimeSpan(06, 0, 0), // 06:00
            };

            foreach (var horario in horarios)
            {
                // Define a hora de início
                var startDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horario.Hours, horario.Minutes, horario.Seconds);

                // Verifica se a hora de início já passou hoje, caso contrário, define para amanhã
                if (DateTime.Now > startDateTime)
                {
                    startDateTime = startDateTime.AddDays(1);
                }

                // Calcula o tempo restante até a hora de início
                var timeToStart = startDateTime - DateTime.Now;

                // Cria o timer para o horário atual
                _timer = new Timer(Registrar, null, timeToStart, TimeSpan.FromDays(1));
            }

            return Task.CompletedTask;
            //int dueTime = (3 * 60 * 60 + 30 * 60) * 1000;
            //_timer = new Timer(Registrar, null, dueTime, dueTime);

            //return Task.CompletedTask;
        }
        private void Registrar(object state)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var processoTramitacaoRepositorio = scope.ServiceProvider.GetRequiredService<IProcessoTramitacaoRepositorio>();
                try
                {
                    processoTramitacaoRepositorio.AtualizaPazo();
                    Log.ForContext("Acao", $"RotinaPrazo").Information($"Rotina dos prazos concluída com sucesso.");
                }
                catch (Exception)
                {
                    Log.ForContext("Acao", $"RotinaPrazo").Warning($"Falha no processo de rotina dos prazos.");
                    throw new Exception("Falha no processo de rotina dos prazos.");
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
