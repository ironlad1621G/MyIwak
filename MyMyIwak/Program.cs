using System;
using System.Windows.Forms;
using MyMyIwak.Views;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new FormTampilanAwal());

    }
}