namespace MyMyIwak.Views
{
    partial class FormDashboardOwner
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
            sidebarOwner1 = new SidebarOwner();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // sidebarOwner1
            // 
            sidebarOwner1.Location = new Point(-3, -30);
            sidebarOwner1.Name = "sidebarOwner1";
            sidebarOwner1.Size = new Size(497, 1080);
            sidebarOwner1.TabIndex = 0;
            sidebarOwner1.Load += sidebarOwner1_Load;
            // 
            // panel1
            // 
            panel1.Location = new Point(623, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 154);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(623, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 154);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(623, 580);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 154);
            panel3.TabIndex = 2;
            // 
            // FormDashboardOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DashboardOwner;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebarOwner1);
            Name = "FormDashboardOwner";
            Text = "FormDashboardOwner";
            ResumeLayout(false);
        }

        #endregion

        private SidebarOwner sidebar1;
        private SidebarOwner sidebarOwner1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}