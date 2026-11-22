namespace MyMyIwak.Views.Customer
{
    partial class dashboardcustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardcustomer));
            sidebarCustomer1 = new SidebarCustomer();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarCustomer1
            // 
            sidebarCustomer1.Location = new Point(-1, -4);
            sidebarCustomer1.Name = "sidebarCustomer1";
            sidebarCustomer1.Size = new Size(497, 1080);
            sidebarCustomer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(617, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 415);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(1025, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 415);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(1432, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 415);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(15, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 286);
            panel4.TabIndex = 2;
            //panel4.Paint += this.panel4_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(16, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 286);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(16, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 286);
            panel6.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 311);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 0;
            label1.Text = "Ikan Cupang Biru";
            //label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 311);
            label2.Name = "label2";
            label2.Size = new Size(249, 32);
            label2.TabIndex = 3;
            label2.Text = "Ikan Cupang Orange";
            //label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 311);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 4;
            label3.Text = "Ikan Cupang Hijau";
            //label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 346);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 4;
            label4.Text = "Rp. 25.000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 376);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // dashboardcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebarCustomer1);
            Cursor = Cursors.SizeNS;
            Name = "dashboardcustomer";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SidebarCustomer sidebarCustomer1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}