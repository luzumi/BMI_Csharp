﻿namespace BMI_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rB_mann = new System.Windows.Forms.RadioButton();
            this.rB_frau = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtB_alter = new System.Windows.Forms.MaskedTextBox();
            this.mtxtB_gewicht = new System.Windows.Forms.MaskedTextBox();
            this.mtxtB_gross = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_bmi = new System.Windows.Forms.Button();
            this.lbl_test = new System.Windows.Forms.Label();
            this.lbl_test2 = new System.Windows.Forms.Label();
            this.lbl_test3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_summe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rB_mann
            // 
            this.rB_mann.AllowDrop = true;
            this.rB_mann.AutoSize = true;
            this.rB_mann.Location = new System.Drawing.Point(38, 30);
            this.rB_mann.Name = "rB_mann";
            this.rB_mann.Size = new System.Drawing.Size(167, 36);
            this.rB_mann.TabIndex = 0;
            this.rB_mann.Text = "Männlich";
            this.rB_mann.UseVisualStyleBackColor = true;
            this.rB_mann.CheckedChanged += new System.EventHandler(this.rB_mann_CheckedChanged);
            // 
            // rB_frau
            // 
            this.rB_frau.AllowDrop = true;
            this.rB_frau.AutoSize = true;
            this.rB_frau.Location = new System.Drawing.Point(231, 30);
            this.rB_frau.Name = "rB_frau";
            this.rB_frau.Size = new System.Drawing.Size(161, 36);
            this.rB_frau.TabIndex = 1;
            this.rB_frau.Text = "Weiblich";
            this.rB_frau.UseVisualStyleBackColor = true;
            this.rB_frau.CheckedChanged += new System.EventHandler(this.rB_frau_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alter: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Größe:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gewicht: ";
            // 
            // mtxtB_alter
            // 
            this.mtxtB_alter.Location = new System.Drawing.Point(231, 93);
            this.mtxtB_alter.Mask = "000";
            this.mtxtB_alter.Name = "mtxtB_alter";
            this.mtxtB_alter.Size = new System.Drawing.Size(56, 38);
            this.mtxtB_alter.TabIndex = 8;
            this.mtxtB_alter.Visible = false;
            this.mtxtB_alter.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtB_alter_MaskInputRejected);
            this.mtxtB_alter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtB_alter_MouseClick);
            this.mtxtB_alter.TextChanged += new System.EventHandler(this.mtxtB_alter_TextChanged);
            this.mtxtB_alter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtB_alter_KeyDown);
            // 
            // mtxtB_gewicht
            // 
            this.mtxtB_gewicht.Location = new System.Drawing.Point(231, 209);
            this.mtxtB_gewicht.Mask = "000";
            this.mtxtB_gewicht.Name = "mtxtB_gewicht";
            this.mtxtB_gewicht.Size = new System.Drawing.Size(56, 38);
            this.mtxtB_gewicht.TabIndex = 10;
            this.mtxtB_gewicht.Visible = false;
            this.mtxtB_gewicht.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtB_gewicht_MouseClick);
            this.mtxtB_gewicht.TextChanged += new System.EventHandler(this.mtxtB_gewicht_TextChanged);
            // 
            // mtxtB_gross
            // 
            this.mtxtB_gross.Location = new System.Drawing.Point(231, 153);
            this.mtxtB_gross.Mask = "000";
            this.mtxtB_gross.Name = "mtxtB_gross";
            this.mtxtB_gross.Size = new System.Drawing.Size(56, 38);
            this.mtxtB_gross.TabIndex = 9;
            this.mtxtB_gross.Visible = false;
            this.mtxtB_gross.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtB_gross_MaskInputRejected);
            this.mtxtB_gross.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtB_gross_MouseClick);
            this.mtxtB_gross.TextChanged += new System.EventHandler(this.mtxtB_gross_TextChanged);
            this.mtxtB_gross.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtB_gross_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_bmi
            // 
            this.btn_bmi.AllowDrop = true;
            this.btn_bmi.BackColor = System.Drawing.Color.Bisque;
            this.btn_bmi.Font = new System.Drawing.Font("Elephant", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bmi.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_bmi.Image = ((System.Drawing.Image)(resources.GetObject("btn_bmi.Image")));
            this.btn_bmi.Location = new System.Drawing.Point(310, 92);
            this.btn_bmi.Name = "btn_bmi";
            this.btn_bmi.Size = new System.Drawing.Size(82, 155);
            this.btn_bmi.TabIndex = 12;
            this.btn_bmi.Text = "BMI";
            this.btn_bmi.UseVisualStyleBackColor = false;
            this.btn_bmi.Click += new System.EventHandler(this.btn_bmi_Click);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(420, 96);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(74, 32);
            this.lbl_test.TabIndex = 13;
            this.lbl_test.Text = "Alter";
            // 
            // lbl_test2
            // 
            this.lbl_test2.AutoSize = true;
            this.lbl_test2.Location = new System.Drawing.Point(420, 156);
            this.lbl_test2.Name = "lbl_test2";
            this.lbl_test2.Size = new System.Drawing.Size(95, 32);
            this.lbl_test2.TabIndex = 14;
            this.lbl_test2.Text = "Größe";
            // 
            // lbl_test3
            // 
            this.lbl_test3.AutoSize = true;
            this.lbl_test3.Location = new System.Drawing.Point(420, 212);
            this.lbl_test3.Name = "lbl_test3";
            this.lbl_test3.Size = new System.Drawing.Size(118, 32);
            this.lbl_test3.TabIndex = 15;
            this.lbl_test3.Text = "Gewicht";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(645, 37);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 42);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(644, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "close";
            // 
            // lbl_summe
            // 
            this.lbl_summe.AutoSize = true;
            this.lbl_summe.ForeColor = System.Drawing.Color.Red;
            this.lbl_summe.Location = new System.Drawing.Point(304, 263);
            this.lbl_summe.Name = "lbl_summe";
            this.lbl_summe.Size = new System.Drawing.Size(112, 32);
            this.lbl_summe.TabIndex = 18;
            this.lbl_summe.Text = "Summe";
            this.lbl_summe.Click += new System.EventHandler(this.lbl_summe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(753, 862);
            this.Controls.Add(this.lbl_summe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_test3);
            this.Controls.Add(this.lbl_test2);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.btn_bmi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxtB_gross);
            this.Controls.Add(this.mtxtB_gewicht);
            this.Controls.Add(this.mtxtB_alter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rB_frau);
            this.Controls.Add(this.rB_mann);
            this.Name = "Form1";
            this.Text = "Berechne Deinen BMI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rB_mann;
        private System.Windows.Forms.RadioButton rB_frau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtB_alter;
        private System.Windows.Forms.MaskedTextBox mtxtB_gewicht;
        private System.Windows.Forms.MaskedTextBox mtxtB_gross;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_bmi;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.Label lbl_test2;
        private System.Windows.Forms.Label lbl_test3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_summe;
    }
}
