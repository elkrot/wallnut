using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;


namespace Wallnut.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(GlobalExceptionHandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fAuth());
        }

        static void GlobalExceptionHandler(object sender, EventArgs e)
        {
            //Логировать!!
            MessageBox.Show("Ошибка в приложении свяжитесь с разработчиком");
            System.Windows.Forms.Application.Exit();
        }
    }
}
