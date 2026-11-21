using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMyIwak.Views
{
    public partial class FormDaftar : Form
    {
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void PindahHalaman(Form formTujuan)
        {
            using (formTujuan)
            {
                formTujuan.ShowDialog(this);
            }
        }
        private void btnDatar_Click(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNoTelepon_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKonfirmasiPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
