
namespace AdvancedProject.Forms
{
    partial class SmallDialogue
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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.txtfoldername = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnproceed = new FontAwesome.Sharp.IconButton();
            this.btncancel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(113, 26);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(211, 12);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(116, 46);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Select The Location";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtdestination);
            this.panel1.Controls.Add(this.txtfoldername);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(22, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 213);
            this.panel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButton1.IconColor = System.Drawing.Color.Blue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(39, 103);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(113, 40);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(153, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Select Destination Folder";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(220, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(176, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Create Folder(Folder Name)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(298, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "or";
            // 
            // txtdestination
            // 
            this.txtdestination.Location = new System.Drawing.Point(219, 47);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(192, 29);
            this.txtdestination.TabIndex = 3;
            // 
            // txtfoldername
            // 
            this.txtfoldername.Location = new System.Drawing.Point(244, 157);
            this.txtfoldername.Name = "txtfoldername";
            this.txtfoldername.Size = new System.Drawing.Size(132, 29);
            this.txtfoldername.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(243, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = " Destination Folder";
            // 
            // btnproceed
            // 
            this.btnproceed.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnproceed.IconColor = System.Drawing.Color.Blue;
            this.btnproceed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnproceed.Location = new System.Drawing.Point(159, 283);
            this.btnproceed.Name = "btnproceed";
            this.btnproceed.Size = new System.Drawing.Size(77, 51);
            this.btnproceed.TabIndex = 2;
            this.btnproceed.UseVisualStyleBackColor = true;
            this.btnproceed.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // btncancel
            // 
            this.btncancel.IconChar = FontAwesome.Sharp.IconChar.XRay;
            this.btncancel.IconColor = System.Drawing.Color.Blue;
            this.btncancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancel.Location = new System.Drawing.Point(320, 283);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(77, 51);
            this.btncancel.TabIndex = 3;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // SmallDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 346);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnproceed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.htmlLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SmallDialogue";
            this.Text = "SmallDialogue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.TextBox txtfoldername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconButton btnproceed;
        private FontAwesome.Sharp.IconButton btncancel;
    }
}