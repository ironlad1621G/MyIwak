using System;
using System.Windows.Forms;

namespace MyMyIwak.Views
{
    public partial class SidebarOwner : UserControl
    {
        public SidebarOwner()
        {
            InitializeComponent();
        }

        private void PindahHalaman(Form formTujuan)
        {
            using (formTujuan)
            {
                formTujuan.ShowDialog(this.FindForm());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormDashboardOwner());
        }

        private void btnKelolaAkunAdmin_Click(object sender, EventArgs e)
        {
            PindahHalaman(new Owner.FormKelolaAkunAdmin());
        }

        private void btnKelolaInventarisIkan_Click(object sender, EventArgs e)
        {
            PindahHalaman(new Owner.FormKelolaInventarisIkan());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormLogin());
        }
    }
}
