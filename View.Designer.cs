namespace moore_mealy_machines
{
    partial class View
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxAdim1 = new System.Windows.Forms.GroupBox();
            this.btnGecisTablosuOlustur = new System.Windows.Forms.Button();
            this.txtDurumlar = new System.Windows.Forms.TextBox();
            this.txtCiktilar = new System.Windows.Forms.TextBox();
            this.txtAlfabe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMealey = new System.Windows.Forms.RadioButton();
            this.rdbMoore = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxAdim2 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.dtgTablo = new System.Windows.Forms.DataGridView();
            this.gboxAdim3 = new System.Windows.Forms.GroupBox();
            this.rchSonuc = new System.Windows.Forms.RichTextBox();
            this.lblSonucCikti = new System.Windows.Forms.Label();
            this.lblSonucDurumlar = new System.Windows.Forms.Label();
            this.lblSonucGirdi = new System.Windows.Forms.Label();
            this.btnMakineyiCalistir = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxAdim1.SuspendLayout();
            this.gboxAdim2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablo)).BeginInit();
            this.gboxAdim3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxAdim1
            // 
            this.gboxAdim1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAdim1.Controls.Add(this.btnGecisTablosuOlustur);
            this.gboxAdim1.Controls.Add(this.txtDurumlar);
            this.gboxAdim1.Controls.Add(this.txtCiktilar);
            this.gboxAdim1.Controls.Add(this.txtAlfabe);
            this.gboxAdim1.Controls.Add(this.label4);
            this.gboxAdim1.Controls.Add(this.label3);
            this.gboxAdim1.Controls.Add(this.label2);
            this.gboxAdim1.Controls.Add(this.rdbMealey);
            this.gboxAdim1.Controls.Add(this.rdbMoore);
            this.gboxAdim1.Controls.Add(this.label1);
            this.gboxAdim1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gboxAdim1.Location = new System.Drawing.Point(12, 12);
            this.gboxAdim1.Name = "gboxAdim1";
            this.gboxAdim1.Size = new System.Drawing.Size(503, 203);
            this.gboxAdim1.TabIndex = 0;
            this.gboxAdim1.TabStop = false;
            this.gboxAdim1.Text = "1. Girdi Ayarları";
            // 
            // btnGecisTablosuOlustur
            // 
            this.btnGecisTablosuOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGecisTablosuOlustur.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGecisTablosuOlustur.Image = global::moore_mealy_machines.Properties.Resources.edit_table;
            this.btnGecisTablosuOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGecisTablosuOlustur.Location = new System.Drawing.Point(286, 154);
            this.btnGecisTablosuOlustur.Name = "btnGecisTablosuOlustur";
            this.btnGecisTablosuOlustur.Size = new System.Drawing.Size(191, 32);
            this.btnGecisTablosuOlustur.TabIndex = 5;
            this.btnGecisTablosuOlustur.Text = "Geçiş Tablosu Oluştur";
            this.btnGecisTablosuOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGecisTablosuOlustur.UseVisualStyleBackColor = true;
            this.btnGecisTablosuOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDurumlar
            // 
            this.txtDurumlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDurumlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDurumlar.Location = new System.Drawing.Point(126, 119);
            this.txtDurumlar.Name = "txtDurumlar";
            this.txtDurumlar.Size = new System.Drawing.Size(351, 29);
            this.txtDurumlar.TabIndex = 4;
            this.txtDurumlar.Text = "q0,q1,q2";
            // 
            // txtCiktilar
            // 
            this.txtCiktilar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiktilar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCiktilar.Location = new System.Drawing.Point(126, 86);
            this.txtCiktilar.Name = "txtCiktilar";
            this.txtCiktilar.Size = new System.Drawing.Size(351, 29);
            this.txtCiktilar.TabIndex = 3;
            this.txtCiktilar.Text = "0,1";
            // 
            // txtAlfabe
            // 
            this.txtAlfabe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlfabe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlfabe.Location = new System.Drawing.Point(126, 53);
            this.txtAlfabe.Name = "txtAlfabe";
            this.txtAlfabe.Size = new System.Drawing.Size(351, 29);
            this.txtAlfabe.TabIndex = 2;
            this.txtAlfabe.Text = "a,b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Durumlar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çıktılar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Girdiler :";
            // 
            // rdbMealey
            // 
            this.rdbMealey.AutoSize = true;
            this.rdbMealey.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbMealey.Location = new System.Drawing.Point(206, 24);
            this.rdbMealey.Name = "rdbMealey";
            this.rdbMealey.Size = new System.Drawing.Size(78, 25);
            this.rdbMealey.TabIndex = 1;
            this.rdbMealey.Text = "Mealey";
            this.rdbMealey.UseVisualStyleBackColor = true;
            // 
            // rdbMoore
            // 
            this.rdbMoore.AutoSize = true;
            this.rdbMoore.Checked = true;
            this.rdbMoore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbMoore.Location = new System.Drawing.Point(126, 24);
            this.rdbMoore.Name = "rdbMoore";
            this.rdbMoore.Size = new System.Drawing.Size(74, 25);
            this.rdbMoore.TabIndex = 0;
            this.rdbMoore.TabStop = true;
            this.rdbMoore.Text = "Moore";
            this.rdbMoore.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makine Türü :";
            // 
            // gboxAdim2
            // 
            this.gboxAdim2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAdim2.Controls.Add(this.btnOlustur);
            this.gboxAdim2.Controls.Add(this.dtgTablo);
            this.gboxAdim2.Enabled = false;
            this.gboxAdim2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gboxAdim2.Location = new System.Drawing.Point(12, 221);
            this.gboxAdim2.Name = "gboxAdim2";
            this.gboxAdim2.Size = new System.Drawing.Size(503, 243);
            this.gboxAdim2.TabIndex = 10;
            this.gboxAdim2.TabStop = false;
            this.gboxAdim2.Text = "2. Geçiş Tablosu ve Çıktılar";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOlustur.Image = global::moore_mealy_machines.Properties.Resources.robotic_arm;
            this.btnOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOlustur.Location = new System.Drawing.Point(328, 205);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(160, 32);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Makineyi Oluştur";
            this.btnOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // dtgTablo
            // 
            this.dtgTablo.AllowUserToAddRows = false;
            this.dtgTablo.AllowUserToDeleteRows = false;
            this.dtgTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTablo.BackgroundColor = System.Drawing.Color.White;
            this.dtgTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgTablo.Location = new System.Drawing.Point(3, 21);
            this.dtgTablo.Name = "dtgTablo";
            this.dtgTablo.Size = new System.Drawing.Size(497, 171);
            this.dtgTablo.TabIndex = 0;
            // 
            // gboxAdim3
            // 
            this.gboxAdim3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAdim3.Controls.Add(this.rchSonuc);
            this.gboxAdim3.Controls.Add(this.lblSonucCikti);
            this.gboxAdim3.Controls.Add(this.lblSonucDurumlar);
            this.gboxAdim3.Controls.Add(this.lblSonucGirdi);
            this.gboxAdim3.Controls.Add(this.btnMakineyiCalistir);
            this.gboxAdim3.Controls.Add(this.txtKelime);
            this.gboxAdim3.Controls.Add(this.label5);
            this.gboxAdim3.Enabled = false;
            this.gboxAdim3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gboxAdim3.Location = new System.Drawing.Point(12, 470);
            this.gboxAdim3.Name = "gboxAdim3";
            this.gboxAdim3.Size = new System.Drawing.Size(503, 214);
            this.gboxAdim3.TabIndex = 11;
            this.gboxAdim3.TabStop = false;
            this.gboxAdim3.Text = "3. Çalışır Makine";
            // 
            // rchSonuc
            // 
            this.rchSonuc.AcceptsTab = true;
            this.rchSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchSonuc.BackColor = System.Drawing.Color.White;
            this.rchSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchSonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchSonuc.Location = new System.Drawing.Point(105, 106);
            this.rchSonuc.Name = "rchSonuc";
            this.rchSonuc.ReadOnly = true;
            this.rchSonuc.Size = new System.Drawing.Size(383, 102);
            this.rchSonuc.TabIndex = 2;
            this.rchSonuc.Text = "";
            this.rchSonuc.WordWrap = false;
            // 
            // lblSonucCikti
            // 
            this.lblSonucCikti.AutoSize = true;
            this.lblSonucCikti.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonucCikti.Location = new System.Drawing.Point(55, 151);
            this.lblSonucCikti.Name = "lblSonucCikti";
            this.lblSonucCikti.Size = new System.Drawing.Size(43, 19);
            this.lblSonucCikti.TabIndex = 14;
            this.lblSonucCikti.Text = "Çıktı:";
            this.lblSonucCikti.Visible = false;
            // 
            // lblSonucDurumlar
            // 
            this.lblSonucDurumlar.AutoSize = true;
            this.lblSonucDurumlar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonucDurumlar.Location = new System.Drawing.Point(21, 129);
            this.lblSonucDurumlar.Name = "lblSonucDurumlar";
            this.lblSonucDurumlar.Size = new System.Drawing.Size(77, 19);
            this.lblSonucDurumlar.TabIndex = 13;
            this.lblSonucDurumlar.Text = "Durumlar:";
            this.lblSonucDurumlar.Visible = false;
            // 
            // lblSonucGirdi
            // 
            this.lblSonucGirdi.AutoSize = true;
            this.lblSonucGirdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonucGirdi.Location = new System.Drawing.Point(52, 108);
            this.lblSonucGirdi.Name = "lblSonucGirdi";
            this.lblSonucGirdi.Size = new System.Drawing.Size(46, 19);
            this.lblSonucGirdi.TabIndex = 12;
            this.lblSonucGirdi.Text = "Girdi:";
            this.lblSonucGirdi.Visible = false;
            // 
            // btnMakineyiCalistir
            // 
            this.btnMakineyiCalistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakineyiCalistir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMakineyiCalistir.Image = global::moore_mealy_machines.Properties.Resources.power_button;
            this.btnMakineyiCalistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakineyiCalistir.Location = new System.Drawing.Point(319, 63);
            this.btnMakineyiCalistir.Name = "btnMakineyiCalistir";
            this.btnMakineyiCalistir.Size = new System.Drawing.Size(158, 32);
            this.btnMakineyiCalistir.TabIndex = 1;
            this.btnMakineyiCalistir.Text = "Makineyi Çalıştır";
            this.btnMakineyiCalistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakineyiCalistir.UseVisualStyleBackColor = true;
            this.btnMakineyiCalistir.Click += new System.EventHandler(this.btnMakineyiCalistir_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKelime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKelime.Location = new System.Drawing.Point(89, 28);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(388, 29);
            this.txtKelime.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kelime: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 696);
            this.Controls.Add(this.gboxAdim3);
            this.Controls.Add(this.gboxAdim2);
            this.Controls.Add(this.gboxAdim1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomata Sonlu Durum Makineleri - Ahmet Can Aydemir - Kasım 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxAdim1.ResumeLayout(false);
            this.gboxAdim1.PerformLayout();
            this.gboxAdim2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablo)).EndInit();
            this.gboxAdim3.ResumeLayout(false);
            this.gboxAdim3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxAdim1;
        private System.Windows.Forms.TextBox txtDurumlar;
        private System.Windows.Forms.TextBox txtCiktilar;
        private System.Windows.Forms.TextBox txtAlfabe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMealey;
        private System.Windows.Forms.RadioButton rdbMoore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGecisTablosuOlustur;
        private System.Windows.Forms.GroupBox gboxAdim2;
        private System.Windows.Forms.DataGridView dtgTablo;
        private System.Windows.Forms.GroupBox gboxAdim3;
        private System.Windows.Forms.Button btnMakineyiCalistir;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.RichTextBox rchSonuc;
        private System.Windows.Forms.Label lblSonucCikti;
        private System.Windows.Forms.Label lblSonucDurumlar;
        private System.Windows.Forms.Label lblSonucGirdi;
    }
}

