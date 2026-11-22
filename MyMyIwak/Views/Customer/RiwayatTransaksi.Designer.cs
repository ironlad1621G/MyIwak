
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMyIwak.Views.Customer
{
    partial class RiwayatTransaksi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            sidebarCustomer1 = new SidebarCustomer();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dgvRiwayat = new DataGridView();
            aksi = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // sidebarCustomer1
            // 
            sidebarCustomer1.Location = new Point(0, 0);
            sidebarCustomer1.Name = "sidebarCustomer1";
            sidebarCustomer1.Size = new Size(497, 1080);
            sidebarCustomer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(605, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 135);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(927, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 135);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(1240, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 135);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(1548, 181);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 135);
            panel4.TabIndex = 4;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(245, 248, 252);
            dgvRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(21, 90, 158);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(21, 90, 158);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvRiwayat.ColumnHeadersHeight = 45;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, aksi });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle8.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(225, 240, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle8;
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.GridColor = Color.FromArgb(230, 230, 230);
            dgvRiwayat.Location = new Point(530, 400);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowTemplate.Height = 45;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.Size = new Size(1300, 350);
            dgvRiwayat.TabIndex = 0;
            dgvRiwayat.CellContentClick += dgvRiwayat_CellContentClick;
            dgvRiwayat.CellFormatting += dgvRiwayat_CellFormatting;
            // 
            // aksi
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(0, 90, 220);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(225, 240, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(0, 90, 220);
            aksi.DefaultCellStyle = dataGridViewCellStyle7;
            aksi.FlatStyle = FlatStyle.Flat;
            aksi.HeaderText = "Aksi";
            aksi.Name = "aksi";
            aksi.ReadOnly = true;
            aksi.Text = "Beri Komentar";
            aksi.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "No.";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Jenis Barang";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tanggal";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Total";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(589, 65);
            label1.Name = "label1";
            label1.Size = new Size(568, 86);
            label1.TabIndex = 5;
            label1.Text = "Riwayat Transaksi";
            // 
            // RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label1);
            Controls.Add(dgvRiwayat);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebarCustomer1);
            Name = "RiwayatTransaksi";
            Text = "RiwayatTransaksi";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SidebarCustomer sidebarCustomer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvRiwayat;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn aksi;
        private Label label1;
    }
}
