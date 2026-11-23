
namespace MyMyIwak.Views.Owner
{
    partial class FormKelolaInventarisIkan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaInventarisIkan));
            sidebarOwner1 = new SidebarOwner();
            inventaris1 = new Panel();
            inventaris2 = new Panel();
            inventaris3 = new Panel();
            panel4 = new Panel();
            panelHeader = new Panel();
            lblJudul = new Label();
            lblSubjudul = new Label();
            btnTambahData = new Button();
            dgvIkan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            inventaris1.SuspendLayout();
            inventaris2.SuspendLayout();
            inventaris3.SuspendLayout();
            panel4.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIkan).BeginInit();
            SuspendLayout();
            // 
            // sidebarOwner1
            // 
            sidebarOwner1.Location = new Point(0, 0);
            sidebarOwner1.Name = "sidebarOwner1";
            sidebarOwner1.Size = new Size(497, 1080);
            sidebarOwner1.TabIndex = 0;
            // 
            // inventaris1
            // 
            inventaris1.BackColor = Color.Transparent;
            inventaris1.Controls.Add(label2);
            inventaris1.Controls.Add(label1);
            inventaris1.Location = new Point(562, 192);
            inventaris1.Name = "inventaris1";
            inventaris1.Size = new Size(255, 118);
            inventaris1.TabIndex = 1;
            // 
            // inventaris2
            // 
            inventaris2.BackColor = Color.Transparent;
            inventaris2.Controls.Add(label4);
            inventaris2.Controls.Add(label3);
            inventaris2.Location = new Point(853, 192);
            inventaris2.Name = "inventaris2";
            inventaris2.Size = new Size(255, 118);
            inventaris2.TabIndex = 2;
            // 
            // inventaris3
            // 
            inventaris3.BackColor = Color.Transparent;
            inventaris3.Controls.Add(label7);
            inventaris3.Controls.Add(label5);
            inventaris3.Location = new Point(1142, 192);
            inventaris3.Name = "inventaris3";
            inventaris3.Size = new Size(255, 118);
            inventaris3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(1432, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 118);
            panel4.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(25, 55, 90);
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Controls.Add(lblSubjudul);
            panelHeader.Controls.Add(btnTambahData);
            panelHeader.Location = new Point(530, 350);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 75);
            panelHeader.TabIndex = 1;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(20, 10);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(152, 28);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Inventaris Ikan";
            // 
            // lblSubjudul
            // 
            lblSubjudul.AutoSize = true;
            lblSubjudul.Font = new Font("Segoe UI", 9F);
            lblSubjudul.ForeColor = Color.FromArgb(210, 220, 235);
            lblSubjudul.Location = new Point(22, 43);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(183, 15);
            lblSubjudul.TabIndex = 1;
            lblSubjudul.Text = "Kelola dan pantau stok ikan Anda";
            // 
            // btnTambahData
            // 
            btnTambahData.BackColor = Color.FromArgb(16, 185, 129);
            btnTambahData.Cursor = Cursors.Hand;
            btnTambahData.FlatAppearance.BorderSize = 0;
            btnTambahData.FlatStyle = FlatStyle.Flat;
            btnTambahData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTambahData.ForeColor = Color.White;
            btnTambahData.Location = new Point(1135, 18);
            btnTambahData.Name = "btnTambahData";
            btnTambahData.Size = new Size(140, 38);
            btnTambahData.TabIndex = 2;
            btnTambahData.Text = "+ Tambah Data";
            btnTambahData.UseVisualStyleBackColor = false;
            // 
            // dgvIkan
            // 
            dgvIkan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvIkan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIkan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIkan.BackgroundColor = Color.White;
            dgvIkan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 244, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 48, 65);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvIkan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvIkan.ColumnHeadersHeight = 48;
            dgvIkan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, edit });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvIkan.DefaultCellStyle = dataGridViewCellStyle4;
            dgvIkan.EnableHeadersVisualStyles = false;
            dgvIkan.GridColor = Color.FromArgb(235, 238, 243);
            dgvIkan.Location = new Point(530, 425);
            dgvIkan.Name = "dgvIkan";
            dgvIkan.RowHeadersVisible = false;
            dgvIkan.RowTemplate.Height = 43;
            dgvIkan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIkan.Size = new Size(1300, 480);
            dgvIkan.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "No.";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Jenis Barang";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Warna Barang";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Stok Barang";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Harga Barang";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // edit
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            edit.DefaultCellStyle = dataGridViewCellStyle3;
            edit.FlatStyle = FlatStyle.Flat;
            edit.HeaderText = "Aksi";
            edit.Name = "edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 5;
            label1.Text = "TOTAL JENIS IKAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label2.Location = new Point(18, 54);
            label2.Name = "label2";
            label2.Size = new Size(35, 41);
            label2.TabIndex = 6;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(23, 15);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 7;
            label3.Text = "TOTAL STOK TERSEDIA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label4.Location = new Point(23, 54);
            label4.Name = "label4";
            label4.Size = new Size(35, 41);
            label4.TabIndex = 7;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.Location = new Point(24, 15);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 8;
            label5.Text = "BARANG MASUK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.Location = new Point(26, 15);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 9;
            label6.Text = "BARANG KELUAR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label7.Location = new Point(24, 54);
            label7.Name = "label7";
            label7.Size = new Size(35, 41);
            label7.TabIndex = 8;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            label8.Location = new Point(26, 54);
            label8.Name = "label8";
            label8.Size = new Size(35, 41);
            label8.TabIndex = 9;
            label8.Text = "0";
            // 
            // FormKelolaInventarisIkan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(dgvIkan);
            Controls.Add(panelHeader);
            Controls.Add(panel4);
            Controls.Add(inventaris3);
            Controls.Add(inventaris2);
            Controls.Add(inventaris1);
            Controls.Add(sidebarOwner1);
            Name = "FormKelolaInventarisIkan";
            Text = "FormKelolaInventarisIkan";
            inventaris1.ResumeLayout(false);
            inventaris1.PerformLayout();
            inventaris2.ResumeLayout(false);
            inventaris2.PerformLayout();
            inventaris3.ResumeLayout(false);
            inventaris3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIkan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SidebarOwner sidebarOwner1;
        private Panel inventaris1;
        private Panel inventaris2;
        private Panel inventaris3;
        private Panel panel4;

        private Panel panelHeader;
        private Label lblJudul;
        private Label lblSubjudul;
        private Button btnTambahData;
        private DataGridView dgvIkan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn edit;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label5;
        private Label label8;
        private Label label6;
    }
}
