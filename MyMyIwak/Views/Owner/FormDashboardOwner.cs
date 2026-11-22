using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMyIwak.Views
{
    public partial class FormDashboardOwner : Form
    {
        public FormDashboardOwner()
        {
            InitializeComponent();
        }

        public void TampilkanDashboardOwner(
            int totalAdmin,
            int totalVarianIkan,
            int totalStokIkan)
        {
            lblTotalAdmin.Text = totalAdmin.ToString();
            lblTotalVarianIkan.Text = totalVarianIkan.ToString();
            lblTotalStokIkan.Text = totalStokIkan.ToString();
        }

        private void sidebar1_Load(object sender, EventArgs e)
        {
        }

        private void sidebarOwner1_Load(object sender, EventArgs e)
        {
        }

        private void FormDashboardOwner_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblTotalAdmin_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalVarianIkan_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalStokIkan_Click(object sender, EventArgs e)
        {
        }
    }
}