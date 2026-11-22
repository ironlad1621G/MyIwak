namespace MyMyIwak.Views.Admin
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            sidebarAdmin1 = new SidebarAdmin();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // sidebarAdmin1
            // 
            sidebarAdmin1.Location = new Point(0, 0);
            sidebarAdmin1.Name = "sidebarAdmin1";
            sidebarAdmin1.Size = new Size(497, 1080);
            sidebarAdmin1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(573, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 152);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(573, 441);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 152);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(1023, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 152);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(1023, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(365, 152);
            panel4.TabIndex = 3;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebarAdmin1);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}