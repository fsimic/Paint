namespace PaintProjectWFAproba
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.debljina = new System.Windows.Forms.ToolStripTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.pozadinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olovka = new System.Windows.Forms.ToolStripButton();
            this.boja = new System.Windows.Forms.ToolStripButton();
            this.pravokutnik = new System.Windows.Forms.ToolStripButton();
            this.elipsa = new System.Windows.Forms.ToolStripButton();
            this.ispunaBojom = new System.Windows.Forms.ToolStripButton();
            this.fill = new System.Windows.Forms.ToolStripButton();
            this.pravokutnikPrazni = new System.Windows.Forms.ToolStripButton();
            this.elipsaPrazna = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem,
            this.spremiToolStripMenuItem,
            this.otvoriToolStripMenuItem,
            this.pozadinaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // noviToolStripMenuItem
            // 
            this.noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            this.noviToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.noviToolStripMenuItem.Text = "Novi";
            this.noviToolStripMenuItem.Click += new System.EventHandler(this.noviToolStripMenuItem_Click);
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.spremiToolStripMenuItem.Text = "Spremi";
            this.spremiToolStripMenuItem.Click += new System.EventHandler(this.spremiToolStripMenuItem_Click);
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.otvoriToolStripMenuItem.Text = "Otvori";
            this.otvoriToolStripMenuItem.Click += new System.EventHandler(this.otvoriToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.olovka,
            this.boja,
            this.toolStripLabel1,
            this.debljina,
            this.pravokutnik,
            this.elipsa,
            this.ispunaBojom,
            this.fill,
            this.pravokutnikPrazni,
            this.elipsaPrazna});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 40, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(64, 442);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 13);
            this.toolStripLabel1.Text = "debljina";
            // 
            // debljina
            // 
            this.debljina.Name = "debljina";
            this.debljina.Size = new System.Drawing.Size(45, 21);
            this.debljina.Text = "1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(605, 431);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Izadji";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pozadinaToolStripMenuItem
            // 
            this.pozadinaToolStripMenuItem.Name = "pozadinaToolStripMenuItem";
            this.pozadinaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pozadinaToolStripMenuItem.Text = "Pozadina";
            this.pozadinaToolStripMenuItem.Click += new System.EventHandler(this.pozadinaToolStripMenuItem_Click);
            // 
            // olovka
            // 
            this.olovka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.olovka.Image = global::PaintProjectWFAproba.Properties.Resources.paint_brush_icon;
            this.olovka.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.olovka.Name = "olovka";
            this.olovka.Size = new System.Drawing.Size(23, 20);
            this.olovka.Text = "olovka";
            // 
            // boja
            // 
            this.boja.BackColor = System.Drawing.Color.Red;
            this.boja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boja.Image = global::PaintProjectWFAproba.Properties.Resources.bojaaa;
            this.boja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boja.Name = "boja";
            this.boja.Size = new System.Drawing.Size(23, 20);
            this.boja.Text = "boja";
            this.boja.Click += new System.EventHandler(this.boja_Click);
            // 
            // pravokutnik
            // 
            this.pravokutnik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pravokutnik.Image = global::PaintProjectWFAproba.Properties.Resources.shape_square;
            this.pravokutnik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pravokutnik.Name = "pravokutnik";
            this.pravokutnik.Size = new System.Drawing.Size(23, 20);
            this.pravokutnik.Text = "pravokutnik s ispunom";
            this.pravokutnik.Click += new System.EventHandler(this.pravokutnik_Click);
            // 
            // elipsa
            // 
            this.elipsa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elipsa.Image = global::PaintProjectWFAproba.Properties.Resources.sport_golf;
            this.elipsa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.elipsa.Name = "elipsa";
            this.elipsa.Size = new System.Drawing.Size(23, 20);
            this.elipsa.Text = "elipsa s ispunom";
            this.elipsa.Click += new System.EventHandler(this.elipsa_Click);
            // 
            // ispunaBojom
            // 
            this.ispunaBojom.BackColor = System.Drawing.Color.White;
            this.ispunaBojom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ispunaBojom.Image = global::PaintProjectWFAproba.Properties.Resources.paintcan;
            this.ispunaBojom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ispunaBojom.Name = "ispunaBojom";
            this.ispunaBojom.Size = new System.Drawing.Size(23, 20);
            this.ispunaBojom.Text = "boja pozadine";
            this.ispunaBojom.Click += new System.EventHandler(this.ispunaBojom_Click);
            // 
            // fill
            // 
            this.fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fill.Image = global::PaintProjectWFAproba.Properties.Resources.clr;
            this.fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(23, 20);
            this.fill.Text = "ocisti platno";
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // pravokutnikPrazni
            // 
            this.pravokutnikPrazni.BackColor = System.Drawing.SystemColors.Window;
            this.pravokutnikPrazni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pravokutnikPrazni.Image = global::PaintProjectWFAproba.Properties.Resources.pravokutnikPrazni;
            this.pravokutnikPrazni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pravokutnikPrazni.Name = "pravokutnikPrazni";
            this.pravokutnikPrazni.Size = new System.Drawing.Size(23, 20);
            this.pravokutnikPrazni.Text = "pravokutnik";
            this.pravokutnikPrazni.Click += new System.EventHandler(this.pravokutnikPrazni_Click);
            // 
            // elipsaPrazna
            // 
            this.elipsaPrazna.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elipsaPrazna.Image = global::PaintProjectWFAproba.Properties.Resources.elipsaPrazna;
            this.elipsaPrazna.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.elipsaPrazna.Name = "elipsaPrazna";
            this.elipsaPrazna.Size = new System.Drawing.Size(23, 20);
            this.elipsaPrazna.Text = "elipsa";
            this.elipsaPrazna.Click += new System.EventHandler(this.elipsaPrazna_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint Program";
       //     this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton olovka;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox debljina;
        private System.Windows.Forms.ToolStripButton pravokutnik;
        private System.Windows.Forms.ToolStripButton elipsa;
        private System.Windows.Forms.ToolStripButton ispunaBojom;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton boja;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozadinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton fill;
        private System.Windows.Forms.ToolStripButton pravokutnikPrazni;
        private System.Windows.Forms.ToolStripButton elipsaPrazna;
    }
}

