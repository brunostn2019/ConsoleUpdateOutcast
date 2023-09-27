using ConsoleAtualizaDadosOutcast.sql;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAtualizaDadosOutcast
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                try
                {
                    SQLite.ConfigurarPlayers();
                    SQLite.ConfigurarLoot();
                    string directory = "C:/dev/StatsOutcast"; // directory of the git repository
                    //using (PowerShell powershell = PowerShell.Create())
                    //{
                    //    // this changes from the user folder that PowerShell starts up with to your git repository
                    //    powershell.AddScript($"cd {directory}");

                    //    powershell.AddScript(@"git init");
                    //    powershell.AddScript(@"git add database.db");
                    //    powershell.AddScript(@"git commit -m 'git commit from PowerShell in C#'");
                    //    powershell.AddScript(@"git push");

                    //    Collection<PSObject> results = powershell.Invoke();
                    //}

                    Thread.Sleep(2000000);

                }
                catch (Exception)
                {


                }

            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }
    }
}
