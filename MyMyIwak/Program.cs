using System;
using System.Windows.Forms;
using MyMyIwak.Views.Owner;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
        Application.Run(new FormDashboardOwner());
=======
        Application.Run(new MyMyIwak.Views.Owner.KelolaAkunAdmin());
>>>>>>> 379c626 (Dafa gay banget)
    }
}