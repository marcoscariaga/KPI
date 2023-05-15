using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class RotinaTramitacaoHostedServico : IHostedService, IDisposable
    {
        private Timer _timer;

        public IServiceProvider ServiceProvider { get; set; }

        public RotinaTramitacaoHostedServico(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            //var horarios = new List<TimeSpan>
            //{
            //    new TimeSpan(21, 0, 0), // 20:00
            //    new TimeSpan(02, 30, 0), // 02:00
            //    new TimeSpan(06, 0, 0), // 06:00
            //    new TimeSpan(18, 45, 0) // 18:45
            //};

            //foreach (var horario in horarios)
            //{
            //    // Define a hora de início
            //    var startDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, horario.Hours, horario.Minutes, horario.Seconds);

            //    // Verifica se a hora de início já passou hoje, caso contrário, define para amanhã
            //    if (DateTime.Now > startDateTime)
            //    {
            //        startDateTime = startDateTime.AddDays(1);
            //    }

            //    // Calcula o tempo restante até a hora de início
            //    var timeToStart = startDateTime - DateTime.Now;

            //    // Cria o timer para o horário atual
            //    _timer = new Timer(Registrar, null, timeToStart, TimeSpan.FromDays(1));
            //}

            //return Task.CompletedTask;
            _timer = new Timer(Registrar, null, 0, 10000);

            return Task.CompletedTask;
        }
        private void Registrar(object state)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var processoRepositorio = scope.ServiceProvider.GetRequiredService<IProcessoRepositorio>();
                var processoTramitacaoServico = scope.ServiceProvider.GetRequiredService<IProcessoTramitacaoDominioServico>();
                var processoTramitacaoRepositorio = scope.ServiceProvider.GetRequiredService<IProcessoTramitacaoRepositorio>();

                var processos = processoRepositorio.ListarAtivos();

                foreach (var processo in processos)
                {
                    var tramitacao = new ProcessoTramitacao()
                    {
                        NumeroProcesso = processo.NumProcesso,
                        IdProcesso = processo.Id
                    };
                    processoTramitacaoServico.Atualizar(tramitacao);
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
