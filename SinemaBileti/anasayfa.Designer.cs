﻿namespace SinemaBileti
{
    partial class anasayfa
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
            this.SuspendLayout();
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaBileti.Properties.Resources.EMPIRE_75;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anasayfa";
            this.Size = new System.Drawing.Size(0, 0);
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
