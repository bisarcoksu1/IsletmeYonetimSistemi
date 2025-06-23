namespace IsletmeYonetimSistemi
{
    partial class FormMusteriler
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriler));
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dataGridView1 = new DataGridView();
            lblAdSoyad = new Label();
            lblTelefon = new Label();
            lblEmail = new Label();
            lblAdres = new Label();
            pictureBox1 = new PictureBox();
            txtSifre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Anchor = AnchorStyles.Top;
            txtAdSoyad.Location = new Point(100, 20);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(268, 27);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtTelefon
            // 
            txtTelefon.Anchor = AnchorStyles.Top;
            txtTelefon.Location = new Point(100, 60);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(268, 27);
            txtTelefon.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(100, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtAdres
            // 
            txtAdres.Anchor = AnchorStyles.Top;
            txtAdres.Location = new Point(100, 140);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(268, 60);
            txtAdres.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top;
            btnEkle.BackColor = Color.FromArgb(255, 192, 192);
            btnEkle.Location = new Point(403, 37);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 30);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top;
            btnGuncelle.BackColor = Color.FromArgb(128, 255, 128);
            btnGuncelle.Location = new Point(403, 73);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 30);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.FromArgb(128, 255, 255);
            btnSil.Location = new Point(403, 113);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 30);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.Top;
            btnTemizle.BackColor = Color.FromArgb(128, 128, 255);
            btnTemizle.Location = new Point(403, 153);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(100, 30);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(30, 237);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(852, 200);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Anchor = AnchorStyles.Top;
            lblAdSoyad.Location = new Point(20, 20);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(100, 23);
            lblAdSoyad.TabIndex = 9;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTelefon
            // 
            lblTelefon.Anchor = AnchorStyles.Top;
            lblTelefon.Location = new Point(20, 60);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(100, 23);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblAdres
            // 
            lblAdres.Anchor = AnchorStyles.Top;
            lblAdres.Location = new Point(20, 140);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(100, 23);
            lblAdres.TabIndex = 12;
            lblAdres.Text = "Adres:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(579, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtSifre
            // 
            txtSifre.Anchor = AnchorStyles.Top;
            txtSifre.Location = new Point(819, 204);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(268, 27);
            txtSifre.TabIndex = 14;
            txtSifre.Text = "123";
            txtSifre.Visible = false;
            // 
            // FormMusteriler
            // 
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(909, 449);
            Controls.Add(txtSifre);
            Controls.Add(pictureBox1);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnTemizle);
            Controls.Add(dataGridView1);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblTelefon);
            Controls.Add(lblEmail);
            Controls.Add(lblAdres);
            Name = "FormMusteriler";
            Text = "Müşteri Takibi";
            Load += FormMusteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private PictureBox pictureBox1;
        private TextBox txtSifre;
    }
}
