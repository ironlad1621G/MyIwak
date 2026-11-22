using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMyIwak.Views.Owner
{
    public partial class FormKelolaAkunAdmin : Form
    {
        public FormKelolaAkunAdmin()
        {
            InitializeComponent();

            IsiDataAwal();
            PerbaruiTotal();

            btnTambahData.Click += btnTambahData_Click;
            dgvAkun.CellContentClick += dgvAkun_CellContentClick;
        }

        // DATA AWAL
        private void IsiDataAwal()
        {
            TambahBaris("Budi Santoso", "budis", "081234567890", true);
            TambahBaris("Siti Rahayu", "sitir", "081234567891", true);
            TambahBaris("Ahmad Fauzi", "ahmadf", "081234567892", false);
        }

        private void TambahBaris(string nama, string username, string telepon, bool aktif)
        {
            int nomor = dgvAkun.Rows.Count + 1;

            dgvAkun.Rows.Add(
                nomor,
                nama,
                username,
                telepon,
                aktif ? "Aktif" : "Nonaktif",
                "Edit",
                aktif ? "Nonaktifkan" : "Aktifkan"
            );
        }

        private void PerbaruiTotal()
        {
            lblTotalAdmin.Text = dgvAkun.Rows.Count.ToString();
        }

        // BUTTON TAMBAH
        private void btnTambahData_Click(object sender, EventArgs e)
        {
            string[] data = TampilkanFormData();

            if (data != null)
            {
                TambahBaris(data[0], data[1], data[2], true);
                PerbaruiTotal();
            }
        }

        // EDIT DAN AKTIF / NONAKTIF
        private void dgvAkun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string kolom = dgvAkun.Columns[e.ColumnIndex].Name;
            DataGridViewRow baris = dgvAkun.Rows[e.RowIndex];

            if (kolom == "Edit")
            {
                string[] data = TampilkanFormData(new string[]
                {
                    baris.Cells["NamaLengkap"].Value.ToString(),
                    baris.Cells["Username"].Value.ToString(),
                    baris.Cells["NoTelepon"].Value.ToString()
                });

                if (data != null)
                {
                    baris.Cells["NamaLengkap"].Value = data[0];
                    baris.Cells["Username"].Value = data[1];
                    baris.Cells["NoTelepon"].Value = data[2];
                }
            }
            else if (kolom == "StatusAksi")
            {
                bool aktif = baris.Cells["Status"].Value.ToString() == "Aktif";

                string pertanyaan = aktif
                    ? "Yakin ingin menonaktifkan akun ini?"
                    : "Yakin ingin mengaktifkan akun ini?";

                DialogResult hasil = MessageBox.Show(
                    pertanyaan,
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hasil == DialogResult.Yes)
                {
                    bool aktifBaru = !aktif;
                    baris.Cells["Status"].Value = aktifBaru ? "Aktif" : "Nonaktif";
                    baris.Cells["StatusAksi"].Value = aktifBaru ? "Nonaktifkan" : "Aktifkan";
                }
            }
        }

        // FORM TAMBAH DAN EDIT
        private string[] TampilkanFormData(string[] data = null)
        {
            Form form = new Form();

            form.Text = data == null ? "Tambah Akun Admin" : "Edit Akun Admin";
            form.Size = new Size(420, 360);
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.BackColor = Color.FromArgb(248, 250, 252);
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            string[] label =
            {
                "Nama Lengkap",
                "Username",
                "No Telepon"
            };

            TextBox[] input = new TextBox[label.Length];

            for (int i = 0; i < label.Length; i++)
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
            simpan.Location = new Point(185, 250);
            simpan.Size = new Size(85, 38);
            simpan.BackColor = Color.FromArgb(16, 185, 129);
            simpan.ForeColor = Color.White;
            simpan.FlatStyle = FlatStyle.Flat;
            simpan.FlatAppearance.BorderSize = 0;

            simpan.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(input[0].Text) ||
                    string.IsNullOrWhiteSpace(input[1].Text) ||
                    string.IsNullOrWhiteSpace(input[2].Text))
                {
                    MessageBox.Show(
                        "Isi semua data dengan benar.",
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
            batal.Location = new Point(285, 250);
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
                    input[2].Text.Trim()
                };
            }

            return null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalAdmin_Click(object sender, EventArgs e)
        {
        }
    }
}
