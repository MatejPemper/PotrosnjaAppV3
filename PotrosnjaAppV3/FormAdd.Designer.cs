namespace PotrosnjaAppV3
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownPotrosnjaUpis = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.pictureBoxCategories = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxNaslov1 = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxNaslov2 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotrosnjaUpis)).BeginInit();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.numericUpDownPotrosnjaUpis);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBoxKategorija);
            this.panel1.Controls.Add(this.panelNav);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBoxNaslov1);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.textBoxNaslov2);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 546);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDownPotrosnjaUpis
            // 
            this.numericUpDownPotrosnjaUpis.Location = new System.Drawing.Point(103, 350);
            this.numericUpDownPotrosnjaUpis.Name = "numericUpDownPotrosnjaUpis";
            this.numericUpDownPotrosnjaUpis.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownPotrosnjaUpis.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(103, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 15);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Odaberite kategoriju:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Items.AddRange(new object[] {
            "Najam ",
            "Režije",
            "Transport",
            "Namirnice",
            "Usluge",
            "Ostalo"});
            this.comboBoxKategorija.Location = new System.Drawing.Point(103, 215);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(162, 21);
            this.comboBoxKategorija.TabIndex = 8;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.Window;
            this.panelNav.Controls.Add(this.pictureBoxCategories);
            this.panelNav.Controls.Add(this.pictureBoxAdd);
            this.panelNav.Controls.Add(this.pictureBoxHome);
            this.panelNav.Location = new System.Drawing.Point(0, 485);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(365, 58);
            this.panelNav.TabIndex = 7;
            // 
            // pictureBoxCategories
            // 
            this.pictureBoxCategories.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategories.Image")));
            this.pictureBoxCategories.Location = new System.Drawing.Point(50, 10);
            this.pictureBoxCategories.Name = "pictureBoxCategories";
            this.pictureBoxCategories.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCategories.TabIndex = 3;
            this.pictureBoxCategories.TabStop = false;
            this.pictureBoxCategories.Click += new System.EventHandler(this.pictureBoxCategories_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.Location = new System.Drawing.Point(273, 10);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 2;
            this.pictureBoxAdd.TabStop = false;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(159, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(57, 58);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(103, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 15);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Unesite potrošeni iznos:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNaslov1
            // 
            this.textBoxNaslov1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNaslov1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNaslov1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNaslov1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNaslov1.Location = new System.Drawing.Point(143, 69);
            this.textBoxNaslov1.Name = "textBoxNaslov1";
            this.textBoxNaslov1.Size = new System.Drawing.Size(199, 37);
            this.textBoxNaslov1.TabIndex = 4;
            this.textBoxNaslov1.Text = "PO";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(71, 69);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(66, 67);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxNaslov2
            // 
            this.textBoxNaslov2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNaslov2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNaslov2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNaslov2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNaslov2.Location = new System.Drawing.Point(143, 103);
            this.textBoxNaslov2.Multiline = true;
            this.textBoxNaslov2.Name = "textBoxNaslov2";
            this.textBoxNaslov2.Size = new System.Drawing.Size(216, 33);
            this.textBoxNaslov2.TabIndex = 2;
            this.textBoxNaslov2.Text = "TROSNJA";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(324, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotrosnjaUpis)).EndInit();
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownPotrosnjaUpis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.PictureBox pictureBoxCategories;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxNaslov1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxNaslov2;
        private System.Windows.Forms.Button buttonClose;
    }
}