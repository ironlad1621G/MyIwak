using System;
using System.Windows.Forms;
using MyMyIwak.Views.Admin;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new KelolaInventarisIkan());

    }
}