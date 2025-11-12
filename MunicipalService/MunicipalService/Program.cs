using System;
using System.Windows.Forms;
using MunicipalServiceApplication.Data;

namespace MunicipalServiceApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FakeDatabase.SeedDemoData();

            Application.Run(new MainForm());
        }
    }
}
