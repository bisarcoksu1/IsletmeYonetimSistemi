namespace IsletmeYonetimSistemi
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnGiris = new Button();
            chkSifreGoster = new CheckBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(chkSifreGoster);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 550);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(398, 44);
            label3.Name = "label3";
            label3.Size = new Size(233, 37);
            label3.TabIndex = 15;
            label3.Text = "ADMİN PANELİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(696, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.Top;
            btnGiris.BackColor = Color.Cyan;
            btnGiris.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            btnGiris.Location = new Point(308, 360);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(142, 27);
            btnGiris.TabIndex = 13;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click_1;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.Anchor = AnchorStyles.Top;
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            chkSifreGoster.Location = new Point(486, 292);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(120, 22);
            chkSifreGoster.TabIndex = 12;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // txtSifre
            // 
            txtSifre.Anchor = AnchorStyles.Top;
            txtSifre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            txtSifre.Location = new Point(296, 292);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(170, 24);
            txtSifre.TabIndex = 11;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Anchor = AnchorStyles.Top;
            txtKullaniciAdi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            txtKullaniciAdi.Location = new Point(296, 232);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(170, 24);
            txtKullaniciAdi.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            label2.Location = new Point(223, 296);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 9;
            label2.Text = "Şifre: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            label1.Location = new Point(178, 238);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı: ";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1060, 550);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnGiris;
        private CheckBox chkSifreGoster;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
    }
}