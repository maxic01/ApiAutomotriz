using FrontAutoProg.Presentacion;
using TP_LAB_Part3.Presentacion;

namespace FrontAutoProg
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Sesion());
        }
    }
}