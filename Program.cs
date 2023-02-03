using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioAlterdata.Interface;
using DesafioAlterdata.Rest;


namespace DesafioAlterdata
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            var Service = new ServiceCollection();
            ConfigureServices(Service);


            Application.Run(new FrmHome());

            using var serviceProvider = Service.BuildServiceProvider();
            var Form1 = serviceProvider.GetRequiredService<FrmHome>();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IDadosAPI, DadosAPI>()
                .AddTransient<FrmHome>();


        }
    }
}
