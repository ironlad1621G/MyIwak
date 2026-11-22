
namespace MyMyIwak.Views.Admin
{
    partial class KelolaInventarisIkan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaInventarisIkan));
            sidebarAdmin1 = new SidebarAdmin();
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
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIkan).BeginInit();
            SuspendLayout();
            // 
            // sidebarAdmin1
            // 
            sidebarAdmin1.Location = new Point(0, 0);
            sidebarAdmin1.Name = "sidebarAdmin1";
            sidebarAdmin1.Size = new Size(497, 1080);
            sidebarAdmin1.TabIndex = 0;
            // 
            // inventaris1
            // 
            inventaris1.Location = new Point(562, 192);
            inventaris1.Name = "inventaris1";
            inventaris1.Size = new Size(255, 118);
            inventaris1.TabIndex = 1;
            // 
            // inventaris2
            // 
            inventaris2.Location = new Point(853, 192);
            inventaris2.Name = "inventaris2";
            inventaris2.Size = new Size(255, 118);
            inventaris2.TabIndex = 2;
            // 
            // inventaris3
            // 
            inventaris3.Location = new Point(1142, 192);
            inventaris3.Name = "inventaris3";
            inventaris3.Size = new Size(255, 118);
            inventaris3.TabIndex = 3;
            // 
            // panel4
            // 
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
            // KelolaInventarisIkan
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
            Controls.Add(sidebarAdmin1);
            Name = "KelolaInventarisIkan";
            Text = "KelolaInventarisIkan";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIkan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
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
    }
}
