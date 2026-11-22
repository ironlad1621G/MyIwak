using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMyIwak.Views.Customer
{
    public partial class ProfilSaya : Form
    {
        public ProfilSaya()
        {
            InitializeComponent();
            TampilkanProfil("Ahmad Fauzi", "ahmadf", "081234567890", "Jl. Melati");
        }

        public void TampilkanProfil(
            string namaLengkap,
            string username,
            string noTelepon,
            string alamat)
        {
            lblNamaLengkap.Text = namaLengkap;
            lblUsername.Text = username;
            lblNoTelepon.Text = noTelepon;
            lblAlamat.Text = alamat;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void lblNamaLengkap_Click(object sender, EventArgs e)
        {
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
        }

        private void lblNoTelepon_Click(object sender, EventArgs e)
        {
        }

        private void lblAlamat_Click(object sender, EventArgs e)
        {
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
