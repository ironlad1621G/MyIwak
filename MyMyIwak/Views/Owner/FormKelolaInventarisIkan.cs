
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MyMyIwak.Views.Owner
{
    public partial class FormKelolaInventarisIkan : Form
    {
        private readonly CultureInfo budaya =
            new CultureInfo("id-ID");

        public FormKelolaInventarisIkan()
        {
            InitializeComponent();
            dgvIkan.Rows.Add(
            dgvIkan.Rows.Count + 1,
            "Ikan Cupang",
            "Air Tawar",
            "20",
            "15000"
);

            btnTambahData.Click += btnTambahData_Click;
            dgvIkan.CellContentClick += dgvIkan_CellContentClick;

            IsiDataAwal();
        }

        // DATA AWAL
        private void IsiDataAwal()
        {
            TambahBaris("Ikan Cupang", "Merah", 100, 100000);
            TambahBaris("Ikan Koi", "Kuning", 50, 200000);
            TambahBaris("Ikan Arwana", "Biru", 20, 300000);
            TambahBaris("Ikan Molly", "Kuning", 50, 200000);
            TambahBaris("Ikan Louhan", "Biru", 100, 300000);
            TambahBaris("Ikan Neon Tetra", "Merah", 20, 100000);
            TambahBaris("Ikan Platy", "Kuning", 50, 200000);
        }

        // MENAMBAHKAN DATA
        private void TambahBaris(
            string jenis, string warna, int stok, decimal harga)
        {
            dgvIkan.Rows.Add(
                dgvIkan.Rows.Count + 1,
                jenis,
                warna,
                stok,
                "Rp. " + harga.ToString("N0", budaya),
                "Edit",
                "Hapus"
            );
        }

        // BUTTON TAMBAH
        private void btnTambahData_Click(object sender, EventArgs e)
        {
            string[] data = TampilkanFormData();

            if (data != null)
            {
                TambahBaris(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    decimal.Parse(data[3], budaya)
                );
            }
        }

        // EDIT DAN HAPUS
        private void dgvIkan_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string kolom = dgvIkan.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvIkan.Rows[e.RowIndex];

            if (kolom == "Edit")
            {
                string harga = row.Cells["Harga"].Value.ToString()
                    .Replace("Rp. ", "")
                    .Replace(".", "");

                string[] data = TampilkanFormData(new string[]
                {
                    row.Cells["Jenis"].Value.ToString(),
                    row.Cells["Warna"].Value.ToString(),
                    row.Cells["Stok"].Value.ToString(),
                    harga
                });

                if (data != null)
                {
                    row.Cells["Jenis"].Value = data[0];
                    row.Cells["Warna"].Value = data[1];
                    row.Cells["Stok"].Value = data[2];
                    row.Cells["Harga"].Value =
                        "Rp. " + decimal.Parse(data[3], budaya)
                        .ToString("N0", budaya);
                }
            }
            else if (kolom == "Hapus")
            {
                DialogResult hasil = MessageBox.Show(
                    "Yakin ingin menghapus data ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hasil == DialogResult.Yes)
                {
                    dgvIkan.Rows.RemoveAt(e.RowIndex);
                    PerbaruiNomor();
                }
            }
        }

        // NOMOR OTOMATIS
        private void PerbaruiNomor()
        {
            for (int i = 0; i < dgvIkan.Rows.Count; i++)
                dgvIkan.Rows[i].Cells["No"].Value = i + 1;
        }

        // FORM TAMBAH DAN EDIT
        private string[] TampilkanFormData(string[] data = null)
        {
            Form form = new Form();

            form.Text = data == null ? "Tambah Data Ikan" : "Edit Data Ikan";
            form.Size = new Size(420, 430);
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.BackColor = Color.FromArgb(248, 250, 252);
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            string[] label =
            {
                "Jenis Barang",
                "Warna Barang",
                "Stok Barang",
                "Harga Barang"
            };

            TextBox[] input = new TextBox[4];

            for (int i = 0; i < 4; i++)
            {
                Label lbl = new Label();
                lbl.Text = label[i];
                lbl.Location = new Point(30, 25 + i * 65);
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                input[i] = new TextBox();
                input[i].Location = new Point(30, 48 + i * 65);
                input[i].Size = new Size(340, 28);

                if (data != null)
                    input[i].Text = data[i];

                form.Controls.Add(lbl);
                form.Controls.Add(input[i]);
            }

            Button simpan = new Button();
            simpan.Text = "Simpan";
            simpan.Location = new Point(185, 310);
            simpan.Size = new Size(85, 38);
            simpan.BackColor = Color.FromArgb(16, 185, 129);
            simpan.ForeColor = Color.White;
            simpan.FlatStyle = FlatStyle.Flat;
            simpan.FlatAppearance.BorderSize = 0;

            simpan.Click += (s, e) =>
            {
                int stok;
                decimal harga;

                if (string.IsNullOrWhiteSpace(input[0].Text) ||
                    string.IsNullOrWhiteSpace(input[1].Text) ||
                    !int.TryParse(input[2].Text, out stok) ||
                    !decimal.TryParse(input[3].Text,
                        NumberStyles.Number, budaya, out harga) ||
                    stok < 0 || harga < 0)
                {
                    MessageBox.Show(
                        "Isi semua data dengan benar. Stok dan harga harus angka.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                form.DialogResult = DialogResult.OK;
                form.Close();
            };

            Button batal = new Button();
            batal.Text = "Batal";
            batal.Location = new Point(285, 310);
            batal.Size = new Size(85, 38);
            batal.DialogResult = DialogResult.Cancel;

            form.Controls.Add(simpan);
            form.Controls.Add(batal);

            form.AcceptButton = simpan;
            form.CancelButton = batal;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                return new string[]
                {
                    input[0].Text.Trim(),
                    input[1].Text.Trim(),
                    input[2].Text,
                    decimal.Parse(input[3].Text, budaya).ToString(budaya)
                };
            }

            return null;
        }
    }
}
