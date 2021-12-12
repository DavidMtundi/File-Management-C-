
namespace AdvancedProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnallzippedfiles = new FontAwesome.Sharp.IconButton();
            this.btnallexecutables = new FontAwesome.Sharp.IconButton();
            this.btnallduplicates = new FontAwesome.Sharp.IconButton();
            this.btnalldocs = new FontAwesome.Sharp.IconButton();
            this.btnallaudios = new FontAwesome.Sharp.IconButton();
            this.btnallvideos = new FontAwesome.Sharp.IconButton();
            this.btnallfiles = new FontAwesome.Sharp.IconButton();
            this.btnhome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnclose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnallzippedfiles);
            this.panelMenu.Controls.Add(this.btnallexecutables);
            this.panelMenu.Controls.Add(this.btnallduplicates);
            this.panelMenu.Controls.Add(this.btnalldocs);
            this.panelMenu.Controls.Add(this.btnallaudios);
            this.panelMenu.Controls.Add(this.btnallvideos);
            this.panelMenu.Controls.Add(this.btnallfiles);
            this.panelMenu.Controls.Add(this.btnhome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(185, 630);
            this.panelMenu.TabIndex = 0;
            // 
            // btnallzippedfiles
            // 
            this.btnallzippedfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallzippedfiles.FlatAppearance.BorderSize = 0;
            this.btnallzippedfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallzippedfiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnallzippedfiles.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.btnallzippedfiles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnallzippedfiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnallzippedfiles.IconSize = 32;
            this.btnallzippedfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallzippedfiles.Location = new System.Drawing.Point(0, 485);
            this.btnallzippedfiles.Name = "btnallzippedfiles";
            this.btnallzippedfiles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnallzippedfiles.Size = new System.Drawing.Size(185, 50);
            this.btnallzippedfiles.TabIndex = 8;
            this.btnallzippedfiles.Text = "All Zipped Files";
            this.btnallzippedfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallzippedfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnallzippedfiles.UseVisualStyleBackColor = true;
            this.btnallzippedfiles.Click += new System.EventHandler(this.btnallzippedfiles_Click);
            // 
            // btnallexecutables
            // 
            this.btnallexecutables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallexecutables.FlatAppearance.BorderSize = 0;
            this.btnallexecutables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallexecutables.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnallexecutables.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnallexecutables.IconColor = System.Drawing.Color.Gainsboro;
            this.btnallexecutables.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnallexecutables.IconSize = 32;
            this.btnallexecutables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallexecutables.Location = new System.Drawing.Point(0, 435);
            this.btnallexecutables.Name = "btnallexecutables";
            this.btnallexecutables.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnallexecutables.Size = new System.Drawing.Size(185, 50);
            this.btnallexecutables.TabIndex = 7;
            this.btnallexecutables.Text = "All Executables";
            this.btnallexecutables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallexecutables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnallexecutables.UseVisualStyleBackColor = true;
            this.btnallexecutables.Click += new System.EventHandler(this.btnallexecutables_Click);
            // 
            // btnallduplicates
            // 
            this.btnallduplicates.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallduplicates.FlatAppearance.BorderSize = 0;
            this.btnallduplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallduplicates.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnallduplicates.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.btnallduplicates.IconColor = System.Drawing.Color.Gainsboro;
            this.btnallduplicates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnallduplicates.IconSize = 32;
            this.btnallduplicates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallduplicates.Location = new System.Drawing.Point(0, 385);
            this.btnallduplicates.Name = "btnallduplicates";
            this.btnallduplicates.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnallduplicates.Size = new System.Drawing.Size(185, 50);
            this.btnallduplicates.TabIndex = 6;
            this.btnallduplicates.Text = "All Duplicates";
            this.btnallduplicates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallduplicates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnallduplicates.UseVisualStyleBackColor = true;
            this.btnallduplicates.Click += new System.EventHandler(this.btnallduplicates_Click);
            // 
            // btnalldocs
            // 
            this.btnalldocs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnalldocs.FlatAppearance.BorderSize = 0;
            this.btnalldocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalldocs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnalldocs.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnalldocs.IconColor = System.Drawing.Color.Gainsboro;
            this.btnalldocs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnalldocs.IconSize = 32;
            this.btnalldocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalldocs.Location = new System.Drawing.Point(0, 335);
            this.btnalldocs.Name = "btnalldocs";
            this.btnalldocs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnalldocs.Size = new System.Drawing.Size(185, 50);
            this.btnalldocs.TabIndex = 5;
            this.btnalldocs.Text = "All Documents";
            this.btnalldocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalldocs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnalldocs.UseVisualStyleBackColor = true;
            this.btnalldocs.Click += new System.EventHandler(this.btnalldocs_Click);
            // 
            // btnallaudios
            // 
            this.btnallaudios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallaudios.FlatAppearance.BorderSize = 0;
            this.btnallaudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallaudios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnallaudios.IconChar = FontAwesome.Sharp.IconChar.FileAudio;
            this.btnallaudios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnallaudios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnallaudios.IconSize = 32;
            this.btnallaudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallaudios.Location = new System.Drawing.Point(0, 285);
            this.btnallaudios.Name = "btnallaudios";
            this.btnallaudios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnallaudios.Size = new System.Drawing.Size(185, 50);
            this.btnallaudios.TabIndex = 4;
            this.btnallaudios.Text = "All Audios";
            this.btnallaudios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallaudios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnallaudios.UseVisualStyleBackColor = true;
            this.btnallaudios.Click += new System.EventHandler(this.btnallaudios_Click);
            // 
            // btnallvideos
            // 
            this.btnallvideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallvideos.FlatAppearance.BorderSize = 0;
            this.btnallvideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallvideos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnallvideos.IconChar = FontAwesome.Sharp.IconChar.FileVideo;
            this.btnallvideos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnallvideos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnallvideos.IconSize = 32;
            this.btnallvideos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallvideos.Location = new System.Drawing.Point(0, 235);
            this.btnallvideos.Name = "btnallvideos";
            this.btnallvideos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnallvideos.Size = new System.Drawing.Size(185, 50);
            this.btnallvideos.TabIndex = 3;
            this.btnallvideos.Text = "All Videos";
            this.btnallvideos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallvideos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnallvideos.UseVisualStyleBackColor = true;
            this.btnallvideos.Click += new System.EventHandler(this.btnallvideos_Click);
            // 
            // btnallfiles
            // 
            this.btnallfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallfiles.FlatAppearance.BorderSize = 0;
            this.btnallfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallfiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnallfiles.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnallfiles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnallfiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnallfiles.IconSize = 32;
            this.btnallfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallfiles.Location = new System.Drawing.Point(0, 185);
            this.btnallfiles.Name = "btnallfiles";
            this.btnallfiles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnallfiles.Size = new System.Drawing.Size(185, 50);
            this.btnallfiles.TabIndex = 2;
            this.btnallfiles.Text = "All Files";
            this.btnallfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnallfiles.UseVisualStyleBackColor = true;
            this.btnallfiles.Click += new System.EventHandler(this.btnallfiles_Click);
            // 
            // btnhome
            // 
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnhome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhome.IconSize = 32;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 135);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnhome.Size = new System.Drawing.Size(185, 50);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(185, 135);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AdvancedProject.Properties.Resources.RealImageLibrary;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.TitleBar.Controls.Add(this.btnclose);
            this.TitleBar.Controls.Add(this.lblTitleChildForm);
            this.TitleBar.Controls.Add(this.iconCurrentChildForm);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(185, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(844, 75);
            this.TitleBar.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnclose.IconColor = System.Drawing.Color.Red;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.IconSize = 45;
            this.btnclose.Location = new System.Drawing.Point(790, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(42, 43);
            this.btnclose.TabIndex = 2;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(74, 34);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(30, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.Controls.Add(this.dataGridView1);
            this.panelDesktop.Controls.Add(this.dataGridView2);
            this.panelDesktop.Controls.Add(this.dataGridView3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(185, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(844, 555);
            this.panelDesktop.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(266, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(275, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(245, 540);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(526, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(245, 540);
            this.dataGridView3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnallduplicates;
        private FontAwesome.Sharp.IconButton btnalldocs;
        private FontAwesome.Sharp.IconButton btnallaudios;
        private FontAwesome.Sharp.IconButton btnallvideos;
        private FontAwesome.Sharp.IconButton btnallfiles;
        private FontAwesome.Sharp.IconButton btnhome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnallzippedfiles;
        private FontAwesome.Sharp.IconButton btnallexecutables;
        private FontAwesome.Sharp.IconButton btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.FlowLayoutPanel panelDesktop;
    }
}

