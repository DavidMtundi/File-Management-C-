
namespace AdvancedProject.UserControls
{
    partial class DiskUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressbardrivespace = new System.Windows.Forms.ProgressBar();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labeltotalspace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelusedspace = new System.Windows.Forms.Label();
            this.drivename = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.progressbardrivespace);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labeltotalspace);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelusedspace);
            this.panel1.Controls.Add(this.drivename);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 140);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(3, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 118);
            this.panel2.TabIndex = 15;
            // 
            // progressbardrivespace
            // 
            this.progressbardrivespace.Location = new System.Drawing.Point(50, 85);
            this.progressbardrivespace.Name = "progressbardrivespace";
            this.progressbardrivespace.Size = new System.Drawing.Size(160, 23);
            this.progressbardrivespace.TabIndex = 14;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hdd;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(60, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 45);
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Remaining";
            // 
            // labeltotalspace
            // 
            this.labeltotalspace.AutoSize = true;
            this.labeltotalspace.Location = new System.Drawing.Point(138, 64);
            this.labeltotalspace.Name = "labeltotalspace";
            this.labeltotalspace.Size = new System.Drawing.Size(57, 15);
            this.labeltotalspace.TabIndex = 11;
            this.labeltotalspace.Text = "unloaded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // labelusedspace
            // 
            this.labelusedspace.AutoSize = true;
            this.labelusedspace.Location = new System.Drawing.Point(68, 65);
            this.labelusedspace.Name = "labelusedspace";
            this.labelusedspace.Size = new System.Drawing.Size(57, 15);
            this.labelusedspace.TabIndex = 9;
            this.labelusedspace.Text = "unloaded";
            // 
            // drivename
            // 
            this.drivename.AutoSize = true;
            this.drivename.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drivename.Location = new System.Drawing.Point(118, 26);
            this.drivename.Name = "drivename";
            this.drivename.Size = new System.Drawing.Size(74, 20);
            this.drivename.TabIndex = 8;
            this.drivename.Text = "unloaded";
            // 
            // DiskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel1);
            this.Name = "DiskUserControl";
            this.Size = new System.Drawing.Size(225, 144);
            this.Load += new System.EventHandler(this.DiskUserControl_Load);
            this.Click += new System.EventHandler(this.DiskUserControl_Click);
            this.DoubleClick += new System.EventHandler(this.DiskUserControl_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiskUserControl_MouseClick);
            this.MouseEnter += new System.EventHandler(this.DiskUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DiskUserControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.DiskUserControl_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ProgressBar progressbardrivespace;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labeltotalspace;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelusedspace;
        public System.Windows.Forms.Label drivename;
    }
}
