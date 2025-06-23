namespace IsletmeYonetimSistemi
{
    partial class FormSiparisler
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisler));
            cmbMusteri = new ComboBox();
            dtpTarih = new DateTimePicker();
            cmbDurum = new ComboBox();
            txtAciklama = new TextBox();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblMusteri = new Label();
            lblTarih = new Label();
            lblDurum = new Label();
            lblAciklama = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.Anchor = AnchorStyles.Top;
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.Location = new Point(120, 20);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(245, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // dtpTarih
            // 
            dtpTarih.Anchor = AnchorStyles.Top;
            dtpTarih.Location = new Point(120, 60);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(245, 27);
            dtpTarih.TabIndex = 1;
            // 
            // cmbDurum
            // 
            cmbDurum.Anchor = AnchorStyles.Top;
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Items.AddRange(new object[] { "Bekliyor", "Hazırlanıyor", "Tamamlandı", "İptal Edildi" });
            cmbDurum.Location = new Point(120, 100);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(245, 28);
            cmbDurum.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Anchor = AnchorStyles.Top;
            txtAciklama.Location = new Point(120, 140);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(245, 60);
            txtAciklama.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(20, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(913, 220);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top;
            btnEkle.BackColor = Color.FromArgb(255, 192, 192);
            btnEkle.Location = new Point(417, 32);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 30);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top;
            btnGuncelle.BackColor = Color.FromArgb(255, 224, 192);
            btnGuncelle.Location = new Point(417, 72);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 30);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.FromArgb(255, 255, 192);
            btnSil.Location = new Point(417, 112);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 30);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.Top;
            btnTemizle.BackColor = Color.FromArgb(192, 255, 192);
            btnTemizle.Location = new Point(417, 152);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(132, 30);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblMusteri
            // 
            lblMusteri.Anchor = AnchorStyles.Top;
            lblMusteri.Location = new Point(20, 20);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.Size = new Size(100, 23);
            lblMusteri.TabIndex = 9;
            lblMusteri.Text = "Müşteri:";
            // 
            // lblTarih
            // 
            lblTarih.Anchor = AnchorStyles.Top;
            lblTarih.Location = new Point(20, 60);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(100, 23);
            lblTarih.TabIndex = 10;
            lblTarih.Text = "Sipariş Tarihi:";
            // 
            // lblDurum
            // 
            lblDurum.Anchor = AnchorStyles.Top;
            lblDurum.Location = new Point(20, 100);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(100, 23);
            lblDurum.TabIndex = 11;
            lblDurum.Text = "Durum:";
            // 
            // lblAciklama
            // 
            lblAciklama.Anchor = AnchorStyles.Top;
            lblAciklama.Location = new Point(20, 140);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(100, 23);
            lblAciklama.TabIndex = 12;
            lblAciklama.Text = "Açıklama:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormSiparisler
            // 
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(945, 470);
            Controls.Add(pictureBox1);
            Controls.Add(cmbMusteri);
            Controls.Add(dtpTarih);
            Controls.Add(cmbDurum);
            Controls.Add(txtAciklama);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnTemizle);
            Controls.Add(dataGridView1);
            Controls.Add(lblMusteri);
            Controls.Add(lblTarih);
            Controls.Add(lblDurum);
            Controls.Add(lblAciklama);
            Name = "FormSiparisler";
            Text = "Sipariş Yönetimi";
            Load += FormSiparisler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblAciklama;
        private PictureBox pictureBox1;
    }
}
