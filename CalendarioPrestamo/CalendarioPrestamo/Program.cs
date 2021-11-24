using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using CalendarioPrestamo.Formularios;
using Domain.Interfaces;
using Infraestructura.Models;

namespace CalendarioPrestamo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CalendarioModel>().As<ICalendarioModel>();
            builder.RegisterType<CalendarioService>().As<ICalendarioService>();
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalendarioFrm(container.Resolve<ICalendarioService>()));
        }
    }
}
