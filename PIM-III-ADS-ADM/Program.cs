

using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.View;

namespace PIM_III_ADS_ADM
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
            Application.Run(new Adm(new PessoaController()));           
         

        }
    }
}