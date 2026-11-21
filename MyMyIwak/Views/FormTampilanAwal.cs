using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyMyIwak.Views
{
    public partial class FormTampilanAwal : Form
    {
        public FormTampilanAwal()
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

        private void button1_Click(object? sender, EventArgs e)
        {
            PindahHalaman(new FormLogin());
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            PindahHalaman(new FormDaftar());
        }

        private void FormTampilanAwal_Load(object sender, EventArgs e)
        {

        }
    }
}