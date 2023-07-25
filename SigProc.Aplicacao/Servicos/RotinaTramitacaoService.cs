﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using Serilog;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            var horarios = new List<TimeSpan>
            { 
                new TimeSpan(17, 00, 0), // 17:00
                new TimeSpan(21, 0, 0), // 21:00
                new TimeSpan(03, 30, 0), // 03:30
                new TimeSpan(09, 16, 0), // 06:00
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

                _timer = new Timer(Registrar, null, timeToStart, TimeSpan.FromHours(4));

            }
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
                try
                {
                    foreach (var processo in processos)
                    {

                        var tramitacao = new ProcessoTramitacao()
                        {
                            NumeroProcesso = processo.NumProcesso,
                            IdProcesso = processo.Id
                        };
                        processoTramitacaoServico.AtualizaTramitacao(tramitacao);
                    }
                    Log.ForContext("Acao", $"RotinaTramitacao").Information($"Rotina das tramitações concluída com sucesso.");
                }
                catch (Exception ex)
                {
                    Log.ForContext("Acao", $"RotinaTramitacao").Warning($"Falha no processo de rotina das tramitações.{ex.Message}");
                    throw new Exception("Falha no processo de rotina das tramitações.");
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