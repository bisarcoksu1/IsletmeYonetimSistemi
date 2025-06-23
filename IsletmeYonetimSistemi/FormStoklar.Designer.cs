namespace IsletmeYonetimSistemi
{
    partial class FormStoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoklar));
            txtUrunAdi = new TextBox();
            txtStokMiktari = new TextBox();
            txtBirim = new TextBox();
            txtAlisFiyati = new TextBox();
            txtSatisFiyati = new TextBox();
            txtTedarikci = new TextBox();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblUrunAdi = new Label();
            lblStokMiktari = new Label();
            lblBirim = new Label();
            lblAlisFiyati = new Label();
            lblSatisFiyati = new Label();
            lblTedarikci = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Anchor = AnchorStyles.Top;
            txtUrunAdi.Location = new Point(120, 20);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(255, 27);
            txtUrunAdi.TabIndex = 0;
            // 
            // txtStokMiktari
            // 
            txtStokMiktari.Anchor = AnchorStyles.Top;
            txtStokMiktari.Location = new Point(120, 60);
            txtStokMiktari.Name = "txtStokMiktari";
            txtStokMiktari.Size = new Size(255, 27);
            txtStokMiktari.TabIndex = 1;
            // 
            // txtBirim
            // 
            txtBirim.Anchor = AnchorStyles.Top;
            txtBirim.Location = new Point(120, 100);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(255, 27);
            txtBirim.TabIndex = 2;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Anchor = AnchorStyles.Top;
            txtAlisFiyati.Location = new Point(120, 140);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(255, 27);
            txtAlisFiyati.TabIndex = 3;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Anchor = AnchorStyles.Top;
            txtSatisFiyati.Location = new Point(120, 180);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(255, 27);
            txtSatisFiyati.TabIndex = 4;
            // 
            // txtTedarikci
            // 
            txtTedarikci.Anchor = AnchorStyles.Top;
            txtTedarikci.Location = new Point(120, 220);
            txtTedarikci.Name = "txtTedarikci";
            txtTedarikci.Size = new Size(255, 27);
            txtTedarikci.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(20, 270);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(895, 200);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top;
            btnEkle.BackColor = Color.FromArgb(255, 128, 128);
            btnEkle.Location = new Point(432, 56);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(138, 35);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top;
            btnGuncelle.BackColor = Color.SpringGreen;
            btnGuncelle.Location = new Point(432, 96);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(138, 35);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.MediumAquamarine;
            btnSil.Location = new Point(432, 136);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(138, 35);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.Top;
            btnTemizle.BackColor = Color.FromArgb(255, 255, 128);
            btnTemizle.Location = new Point(432, 176);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(138, 35);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.Anchor = AnchorStyles.Top;
            lblUrunAdi.Location = new Point(20, 20);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(100, 23);
            lblUrunAdi.TabIndex = 6;
            lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblStokMiktari
            // 
            lblStokMiktari.Anchor = AnchorStyles.Top;
            lblStokMiktari.Location = new Point(20, 60);
            lblStokMiktari.Name = "lblStokMiktari";
            lblStokMiktari.Size = new Size(100, 23);
            lblStokMiktari.TabIndex = 7;
            lblStokMiktari.Text = "Stok Miktarı:";
            // 
            // lblBirim
            // 
            lblBirim.Anchor = AnchorStyles.Top;
            lblBirim.Location = new Point(20, 100);
            lblBirim.Name = "lblBirim";
            lblBirim.Size = new Size(100, 23);
            lblBirim.TabIndex = 8;
            lblBirim.Text = "Birim:";
            // 
            // lblAlisFiyati
            // 
            lblAlisFiyati.Anchor = AnchorStyles.Top;
            lblAlisFiyati.Location = new Point(20, 140);
            lblAlisFiyati.Name = "lblAlisFiyati";
            lblAlisFiyati.Size = new Size(100, 23);
            lblAlisFiyati.TabIndex = 9;
            lblAlisFiyati.Text = "Alış Fiyatı:";
            // 
            // lblSatisFiyati
            // 
            lblSatisFiyati.Anchor = AnchorStyles.Top;
            lblSatisFiyati.Location = new Point(20, 180);
            lblSatisFiyati.Name = "lblSatisFiyati";
            lblSatisFiyati.Size = new Size(100, 23);
            lblSatisFiyati.TabIndex = 10;
            lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // lblTedarikci
            // 
            lblTedarikci.Anchor = AnchorStyles.Top;
            lblTedarikci.Location = new Point(20, 220);
            lblTedarikci.Name = "lblTedarikci";
            lblTedarikci.Size = new Size(100, 23);
            lblTedarikci.TabIndex = 11;
            lblTedarikci.Text = "Tedarikçi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(612, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // FormStoklar
            // 
            BackColor = Color.Cyan;
            ClientSize = new Size(946, 500);
            Controls.Add(pictureBox1);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtStokMiktari);
            Controls.Add(txtBirim);
            Controls.Add(txtAlisFiyati);
            Controls.Add(txtSatisFiyati);
            Controls.Add(txtTedarikci);
            Controls.Add(lblUrunAdi);
            Controls.Add(lblStokMiktari);
            Controls.Add(lblBirim);
            Controls.Add(lblAlisFiyati);
            Controls.Add(lblSatisFiyati);
            Controls.Add(lblTedarikci);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnTemizle);
            Controls.Add(dataGridView1);
            Name = "FormStoklar";
            Text = "Stok Yönetimi";
            Load += FormStoklar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblTedarikci;
        private PictureBox pictureBox1;
    }
}
