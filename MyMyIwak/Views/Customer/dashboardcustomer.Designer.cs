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
            panel1.SuspendLayout();
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
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(617, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 415);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(1025, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 415);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(1432, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 415);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(15, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 286);
            panel4.TabIndex = 2;
            panel4.Paint += this.panel4_Paint;
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
            ResumeLayout(false);
        }

        #endregion

        private SidebarCustomer sidebarCustomer1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
    }
}