namespace MyMyIwak.Views.Owner
{
    partial class FormKelolaAkunAdmin
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaAkunAdmin));

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            sidebarOwner1 = new SidebarOwner();
            panel1 = new Panel();
            lblTotalAdmin = new Label();
            label1 = new Label();

            panelHeader = new Panel();
            lblJudul = new Label();
            lblSubjudul = new Label();
            btnTambahData = new Button();

            dgvAkun = new DataGridView();
            kolomNo = new DataGridViewTextBoxColumn();
            kolomNama = new DataGridViewTextBoxColumn();
            kolomUsername = new DataGridViewTextBoxColumn();
            kolomTelepon = new DataGridViewTextBoxColumn();
            kolomStatus = new DataGridViewTextBoxColumn();
            kolomEdit = new DataGridViewButtonColumn();
            kolomStatusAksi = new DataGridViewButtonColumn();

            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAkun).BeginInit();
            SuspendLayout();

            // 
            // sidebarOwner1
            // 
            sidebarOwner1.Location = new Point(-5, -28);
            sidebarOwner1.Name = "sidebarOwner1";
            sidebarOwner1.Size = new Size(497, 1080);
            sidebarOwner1.TabIndex = 0;

            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalAdmin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(607, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 154);
            panel1.TabIndex = 2;

            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.AutoSize = true;
            lblTotalAdmin.BackColor = Color.Transparent;
            lblTotalAdmin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAdmin.Location = new Point(67, 67);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(54, 65);
            lblTotalAdmin.TabIndex = 4;
            lblTotalAdmin.Text = "0";
            lblTotalAdmin.Click += lblTotalAdmin_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 17);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 3;
            label1.Text = "Total Akun Admin";

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
            lblJudul.Text = "Kelola Akun Admin";

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
            lblSubjudul.Text = "Kelola dan pantau akun admin";

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
            // dgvAkun
            // 
            dgvAkun.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvAkun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAkun.BackgroundColor = Color.White;
            dgvAkun.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 244, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 48, 65);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAkun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAkun.ColumnHeadersHeight = 48;

            kolomNo.HeaderText = "No.";
            kolomNo.Name = "No";

            kolomNama.HeaderText = "Nama Lengkap";
            kolomNama.Name = "NamaLengkap";

            kolomUsername.HeaderText = "Username";
            kolomUsername.Name = "Username";

            kolomTelepon.HeaderText = "No Telepon";
            kolomTelepon.Name = "NoTelepon";

            kolomStatus.HeaderText = "Status";
            kolomStatus.Name = "Status";

            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            kolomEdit.DefaultCellStyle = dataGridViewCellStyle3;
            kolomEdit.FlatStyle = FlatStyle.Flat;
            kolomEdit.HeaderText = "Aksi";
            kolomEdit.Name = "Edit";
            kolomEdit.Text = "Edit";
            kolomEdit.UseColumnTextForButtonValue = true;

            kolomStatusAksi.DefaultCellStyle = dataGridViewCellStyle3;
            kolomStatusAksi.FlatStyle = FlatStyle.Flat;
            kolomStatusAksi.HeaderText = "Aksi";
            kolomStatusAksi.Name = "StatusAksi";
            kolomStatusAksi.Text = "Nonaktifkan";
            kolomStatusAksi.UseColumnTextForButtonValue = true;

            dgvAkun.Columns.AddRange(new DataGridViewColumn[]
            {
                kolomNo,
                kolomNama,
                kolomUsername,
                kolomTelepon,
                kolomStatus,
                kolomEdit,
                kolomStatusAksi
            });

            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAkun.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAkun.EnableHeadersVisualStyles = false;
            dgvAkun.GridColor = Color.FromArgb(235, 238, 243);
            dgvAkun.Location = new Point(530, 425);
            dgvAkun.Name = "dgvAkun";
            dgvAkun.RowHeadersVisible = false;
            dgvAkun.RowTemplate.Height = 43;
            dgvAkun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAkun.Size = new Size(1300, 480);
            dgvAkun.TabIndex = 0;

            // 
            // FormKelolaAkunAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(dgvAkun);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Controls.Add(sidebarOwner1);
            Name = "FormKelolaAkunAdmin";
            Text = "Kelola Akun Admin";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAkun).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SidebarOwner sidebarOwner1;
        private Panel panel1;
        private Label lblTotalAdmin;
        private Label label1;

        private Panel panelHeader;
        private Label lblJudul;
        private Label lblSubjudul;
        private Button btnTambahData;

        private DataGridView dgvAkun;
        private DataGridViewTextBoxColumn kolomNo;
        private DataGridViewTextBoxColumn kolomNama;
        private DataGridViewTextBoxColumn kolomUsername;
        private DataGridViewTextBoxColumn kolomTelepon;
        private DataGridViewTextBoxColumn kolomStatus;
        private DataGridViewButtonColumn kolomEdit;
        private DataGridViewButtonColumn kolomStatusAksi;
    }
}
