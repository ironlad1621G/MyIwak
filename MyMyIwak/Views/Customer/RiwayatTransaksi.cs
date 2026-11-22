
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMyIwak.Views.Customer
{
    public partial class RiwayatTransaksi : Form
    {
        public RiwayatTransaksi()
        {
            InitializeComponent();
        }

        // MENGATUR WARNA STATUS
        private void dgvRiwayat_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex >= 0 &&
                dgvRiwayat.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value?.ToString();

                if (status == "Dikirim")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (status == "Diterima")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
