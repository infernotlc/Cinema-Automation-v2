namespace SinemaBileti
{
    partial class filmEkle
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.filmad = new System.Windows.Forms.Label();
            this.yonetmen = new System.Windows.Forms.Label();
            this.filmtur = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.yapimyil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filmsure = new System.Windows.Forms.TextBox();
            this.yonetmenadi = new System.Windows.Forms.TextBox();
            this.filmturcombo = new System.Windows.Forms.ComboBox();
            this.filmadi = new System.Windows.Forms.TextBox();
            this.filmyil = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.afissec = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnfilmekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Film_İşlemleri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmad
            // 
            this.filmad.AutoSize = true;
            this.filmad.BackColor = System.Drawing.Color.Transparent;
            this.filmad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmad.ForeColor = System.Drawing.Color.White;
            this.filmad.Location = new System.Drawing.Point(42, 156);
            this.filmad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filmad.Name = "filmad";
            this.filmad.Size = new System.Drawing.Size(149, 39);
            this.filmad.TabIndex = 4;
            this.filmad.Text = "Film Adı";
            this.filmad.Click += new System.EventHandler(this.filmad_Click);
            // 
            // yonetmen
            // 
            this.yonetmen.AutoSize = true;
            this.yonetmen.BackColor = System.Drawing.Color.Transparent;
            this.yonetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetmen.ForeColor = System.Drawing.Color.White;
            this.yonetmen.Location = new System.Drawing.Point(42, 237);
            this.yonetmen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yonetmen.Name = "yonetmen";
            this.yonetmen.Size = new System.Drawing.Size(179, 39);
            this.yonetmen.TabIndex = 5;
            this.yonetmen.Text = "Yönetmen";
            // 
            // filmtur
            // 
            this.filmtur.AutoSize = true;
            this.filmtur.BackColor = System.Drawing.Color.Transparent;
            this.filmtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmtur.ForeColor = System.Drawing.Color.White;
            this.filmtur.Location = new System.Drawing.Point(42, 322);
            this.filmtur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filmtur.Name = "filmtur";
            this.filmtur.Size = new System.Drawing.Size(170, 39);
            this.filmtur.TabIndex = 6;
            this.filmtur.Text = "Film Türü";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.BackColor = System.Drawing.Color.Transparent;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.ForeColor = System.Drawing.Color.White;
            this.sure.Location = new System.Drawing.Point(42, 408);
            this.sure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(93, 39);
            this.sure.TabIndex = 7;
            this.sure.Text = "Süre";
            // 
            // yapimyil
            // 
            this.yapimyil.AutoSize = true;
            this.yapimyil.BackColor = System.Drawing.Color.Transparent;
            this.yapimyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapimyil.ForeColor = System.Drawing.Color.White;
            this.yapimyil.Location = new System.Drawing.Point(42, 493);
            this.yapimyil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yapimyil.Name = "yapimyil";
            this.yapimyil.Size = new System.Drawing.Size(178, 39);
            this.yapimyil.TabIndex = 8;
            this.yapimyil.Text = "Yapım Yılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tarih";
            // 
            // filmsure
            // 
            this.filmsure.BackColor = System.Drawing.Color.Black;
            this.filmsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsure.ForeColor = System.Drawing.Color.White;
            this.filmsure.Location = new System.Drawing.Point(255, 408);
            this.filmsure.Margin = new System.Windows.Forms.Padding(4);
            this.filmsure.Name = "filmsure";
            this.filmsure.Size = new System.Drawing.Size(325, 46);
            this.filmsure.TabIndex = 6;
            // 
            // yonetmenadi
            // 
            this.yonetmenadi.BackColor = System.Drawing.Color.Black;
            this.yonetmenadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetmenadi.ForeColor = System.Drawing.Color.White;
            this.yonetmenadi.Location = new System.Drawing.Point(255, 230);
            this.yonetmenadi.Margin = new System.Windows.Forms.Padding(4);
            this.yonetmenadi.Name = "yonetmenadi";
            this.yonetmenadi.Size = new System.Drawing.Size(325, 46);
            this.yonetmenadi.TabIndex = 5;
            // 
            // filmturcombo
            // 
            this.filmturcombo.BackColor = System.Drawing.Color.Black;
            this.filmturcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmturcombo.ForeColor = System.Drawing.Color.White;
            this.filmturcombo.FormattingEnabled = true;
            this.filmturcombo.Location = new System.Drawing.Point(255, 319);
            this.filmturcombo.Margin = new System.Windows.Forms.Padding(4);
            this.filmturcombo.Name = "filmturcombo";
            this.filmturcombo.Size = new System.Drawing.Size(325, 47);
            this.filmturcombo.TabIndex = 4;
            // 
            // filmadi
            // 
            this.filmadi.BackColor = System.Drawing.Color.Black;
            this.filmadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmadi.ForeColor = System.Drawing.Color.White;
            this.filmadi.Location = new System.Drawing.Point(255, 149);
            this.filmadi.Margin = new System.Windows.Forms.Padding(4);
            this.filmadi.Name = "filmadi";
            this.filmadi.Size = new System.Drawing.Size(325, 46);
            this.filmadi.TabIndex = 4;
            // 
            // filmyil
            // 
            this.filmyil.BackColor = System.Drawing.Color.Black;
            this.filmyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmyil.ForeColor = System.Drawing.Color.White;
            this.filmyil.Location = new System.Drawing.Point(255, 486);
            this.filmyil.Margin = new System.Windows.Forms.Padding(4);
            this.filmyil.Name = "filmyil";
            this.filmyil.Size = new System.Drawing.Size(325, 46);
            this.filmyil.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(626, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // afissec
            // 
            this.afissec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.afissec.FlatAppearance.BorderSize = 0;
            this.afissec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afissec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afissec.ForeColor = System.Drawing.Color.White;
            this.afissec.ImageList = this.ımageList1;
            this.afissec.Location = new System.Drawing.Point(677, 692);
            this.afissec.Margin = new System.Windows.Forms.Padding(4);
            this.afissec.Name = "afissec";
            this.afissec.Size = new System.Drawing.Size(223, 52);
            this.afissec.TabIndex = 2;
            this.afissec.Text = "Afiş\r\nSeç";
            this.afissec.UseVisualStyleBackColor = false;
            this.afissec.Click += new System.EventHandler(this.afissec_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnfilmekle.FlatAppearance.BorderSize = 0;
            this.btnfilmekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilmekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilmekle.ForeColor = System.Drawing.Color.White;
            this.btnfilmekle.ImageList = this.ımageList1;
            this.btnfilmekle.Location = new System.Drawing.Point(27, 694);
            this.btnfilmekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(223, 49);
            this.btnfilmekle.TabIndex = 3;
            this.btnfilmekle.Text = "Film \r\nEkle";
            this.btnfilmekle.UseVisualStyleBackColor = false;
            this.btnfilmekle.Click += new System.EventHandler(this.btnfilmekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 568);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 46);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Film_İşlemleri
            // 
            this.Film_İşlemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Film_İşlemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Film_İşlemleri.FlatAppearance.BorderSize = 0;
            this.Film_İşlemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Film_İşlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Film_İşlemleri.ForeColor = System.Drawing.Color.White;
            this.Film_İşlemleri.ImageKey = "(yok)";
            this.Film_İşlemleri.ImageList = this.ımageList1;
            this.Film_İşlemleri.Location = new System.Drawing.Point(351, 691);
            this.Film_İşlemleri.Margin = new System.Windows.Forms.Padding(4);
            this.Film_İşlemleri.Name = "Film_İşlemleri";
            this.Film_İşlemleri.Size = new System.Drawing.Size(229, 52);
            this.Film_İşlemleri.TabIndex = 11;
            this.Film_İşlemleri.Text = "  Film    \r\nİşlemleri";
            this.Film_İşlemleri.UseVisualStyleBackColor = false;
            this.Film_İşlemleri.Click += new System.EventHandler(this.Film_İşlemleri_Click);
            // 
            // filmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaBileti.Properties.Resources.ref_astor_grand_cinema_galerie_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.filmad);
            this.Controls.Add(this.yonetmen);
            this.Controls.Add(this.filmtur);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.yapimyil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmsure);
            this.Controls.Add(this.filmyil);
            this.Controls.Add(this.filmturcombo);
            this.Controls.Add(this.yonetmenadi);
            this.Controls.Add(this.Film_İşlemleri);
            this.Controls.Add(this.filmadi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnfilmekle);
            this.Controls.Add(this.afissec);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, -17);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "filmEkle";
            this.Size = new System.Drawing.Size(1609, 873);
            this.Load += new System.EventHandler(this.filmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox filmturcombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button afissec;
        private System.Windows.Forms.Button btnfilmekle;
        private System.Windows.Forms.TextBox filmyil;
        private System.Windows.Forms.TextBox filmsure;
        private System.Windows.Forms.TextBox yonetmenadi;
        private System.Windows.Forms.TextBox filmadi;
        private System.Windows.Forms.Label filmad;
        private System.Windows.Forms.Label yonetmen;
        private System.Windows.Forms.Label filmtur;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label yapimyil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Film_İşlemleri;
    }
}
