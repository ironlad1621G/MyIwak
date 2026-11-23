
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            sidebarCustomer1 = new SidebarCustomer();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dgvRiwayat = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            aksi = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(605, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 135);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(927, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 135);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1240, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 135);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1548, 181);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 135);
            panel4.TabIndex = 4;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(245, 248, 252);
            dgvRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(21, 90, 158);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(21, 90, 158);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvRiwayat.ColumnHeadersHeight = 45;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, aksi });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle12.Padding = new Padding(8, 0, 5, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(225, 240, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle12;
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
            // aksi
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(0, 90, 220);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(225, 240, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(0, 90, 220);
            aksi.DefaultCellStyle = dataGridViewCellStyle11;
            aksi.FlatStyle = FlatStyle.Flat;
            aksi.HeaderText = "Aksi";
            aksi.Name = "aksi";
            aksi.ReadOnly = true;
            aksi.Text = "Beri Komentar";
            aksi.UseColumnTextForButtonValue = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 17);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 0;
            label2.Text = "MENUNGGU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label3.Location = new Point(20, 57);
            label3.Name = "label3";
            label3.Size = new Size(35, 41);
            label3.TabIndex = 1;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 2;
            label4.Text = "DIKEMAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label5.Location = new Point(22, 57);
            label5.Name = "label5";
            label5.Size = new Size(35, 41);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 17);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 3;
            label6.Text = "DIKIRIM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label7.Location = new Point(19, 57);
            label7.Name = "label7";
            label7.Size = new Size(35, 41);
            label7.TabIndex = 3;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 17);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 4;
            label8.Text = "DITERIMA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label9.Location = new Point(23, 57);
            label9.Name = "label9";
            label9.Size = new Size(35, 41);
            label9.TabIndex = 4;
            label9.Text = "0";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
    }
}
