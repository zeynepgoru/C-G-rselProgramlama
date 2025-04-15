namespace dataodev3
{
    partial class Form1
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
            this.adlabel = new System.Windows.Forms.Label();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.gunlabel = new System.Windows.Forms.Label();
            this.aylabel = new System.Windows.Forms.Label();
            this.yılabel = new System.Windows.Forms.Label();
            this.boylabel = new System.Windows.Forms.Label();
            this.kilolabel = new System.Windows.Forms.Label();
            this.adtextBox = new System.Windows.Forms.TextBox();
            this.kgtextBox = new System.Windows.Forms.TextBox();
            this.boytextBox = new System.Windows.Forms.TextBox();
            this.yıltextBox = new System.Windows.Forms.TextBox();
            this.aytextBox = new System.Windows.Forms.TextBox();
            this.guntextBox = new System.Windows.Forms.TextBox();
            this.soyadtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vkilabel = new System.Windows.Forms.Label();
            this.burclabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vkiYorumlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.Location = new System.Drawing.Point(59, 69);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(23, 16);
            this.adlabel.TabIndex = 0;
            this.adlabel.Text = "ad";
            // 
            // soyadlabel
            // 
            this.soyadlabel.AutoSize = true;
            this.soyadlabel.Location = new System.Drawing.Point(59, 112);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(45, 16);
            this.soyadlabel.TabIndex = 1;
            this.soyadlabel.Text = "soyad";
            // 
            // gunlabel
            // 
            this.gunlabel.AutoSize = true;
            this.gunlabel.Location = new System.Drawing.Point(59, 150);
            this.gunlabel.Name = "gunlabel";
            this.gunlabel.Size = new System.Drawing.Size(85, 16);
            this.gunlabel.TabIndex = 2;
            this.gunlabel.Text = "Dogum Günü";
            // 
            // aylabel
            // 
            this.aylabel.AutoSize = true;
            this.aylabel.Location = new System.Drawing.Point(59, 190);
            this.aylabel.Name = "aylabel";
            this.aylabel.Size = new System.Drawing.Size(73, 16);
            this.aylabel.TabIndex = 3;
            this.aylabel.Text = "Doğum Ayı";
            // 
            // yılabel
            // 
            this.yılabel.AutoSize = true;
            this.yılabel.Location = new System.Drawing.Point(59, 225);
            this.yılabel.Name = "yılabel";
            this.yılabel.Size = new System.Drawing.Size(72, 16);
            this.yılabel.TabIndex = 4;
            this.yılabel.Text = "Doğum Yılı";
            // 
            // boylabel
            // 
            this.boylabel.AutoSize = true;
            this.boylabel.Location = new System.Drawing.Point(59, 261);
            this.boylabel.Name = "boylabel";
            this.boylabel.Size = new System.Drawing.Size(31, 16);
            this.boylabel.TabIndex = 5;
            this.boylabel.Text = "Boy";
            this.boylabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // kilolabel
            // 
            this.kilolabel.AutoSize = true;
            this.kilolabel.Location = new System.Drawing.Point(59, 299);
            this.kilolabel.Name = "kilolabel";
            this.kilolabel.Size = new System.Drawing.Size(28, 16);
            this.kilolabel.TabIndex = 6;
            this.kilolabel.Text = "kilo";
            this.kilolabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // adtextBox
            // 
            this.adtextBox.Location = new System.Drawing.Point(169, 69);
            this.adtextBox.Name = "adtextBox";
            this.adtextBox.Size = new System.Drawing.Size(100, 22);
            this.adtextBox.TabIndex = 7;
            this.adtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kgtextBox
            // 
            this.kgtextBox.Location = new System.Drawing.Point(169, 299);
            this.kgtextBox.Name = "kgtextBox";
            this.kgtextBox.Size = new System.Drawing.Size(100, 22);
            this.kgtextBox.TabIndex = 8;
            // 
            // boytextBox
            // 
            this.boytextBox.Location = new System.Drawing.Point(169, 261);
            this.boytextBox.Name = "boytextBox";
            this.boytextBox.Size = new System.Drawing.Size(100, 22);
            this.boytextBox.TabIndex = 9;
            // 
            // yıltextBox
            // 
            this.yıltextBox.Location = new System.Drawing.Point(169, 225);
            this.yıltextBox.Name = "yıltextBox";
            this.yıltextBox.Size = new System.Drawing.Size(100, 22);
            this.yıltextBox.TabIndex = 10;
            // 
            // aytextBox
            // 
            this.aytextBox.Location = new System.Drawing.Point(169, 190);
            this.aytextBox.Name = "aytextBox";
            this.aytextBox.Size = new System.Drawing.Size(100, 22);
            this.aytextBox.TabIndex = 11;
            // 
            // guntextBox
            // 
            this.guntextBox.Location = new System.Drawing.Point(169, 150);
            this.guntextBox.Name = "guntextBox";
            this.guntextBox.Size = new System.Drawing.Size(100, 22);
            this.guntextBox.TabIndex = 12;
            // 
            // soyadtextBox
            // 
            this.soyadtextBox.Location = new System.Drawing.Point(169, 112);
            this.soyadtextBox.Name = "soyadtextBox";
            this.soyadtextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadtextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "PRESS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "VKİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "VKİ Yorum";
            // 
            // vkilabel
            // 
            this.vkilabel.AutoSize = true;
            this.vkilabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vkilabel.Location = new System.Drawing.Point(445, 75);
            this.vkilabel.Name = "vkilabel";
            this.vkilabel.Size = new System.Drawing.Size(0, 16);
            this.vkilabel.TabIndex = 19;
            // 
            // burclabel
            // 
            this.burclabel.AutoSize = true;
            this.burclabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.burclabel.Location = new System.Drawing.Point(473, 168);
            this.burclabel.Name = "burclabel";
            this.burclabel.Size = new System.Drawing.Size(0, 16);
            this.burclabel.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "BURÇ:";
            // 
            // vkiYorumlabel
            // 
            this.vkiYorumlabel.AutoSize = true;
            this.vkiYorumlabel.Location = new System.Drawing.Point(445, 129);
            this.vkiYorumlabel.Name = "vkiYorumlabel";
            this.vkiYorumlabel.Size = new System.Drawing.Size(0, 16);
            this.vkiYorumlabel.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dataodev3.Properties.Resources.yengec;
            this.pictureBox1.Location = new System.Drawing.Point(461, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 143);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vkiYorumlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.burclabel);
            this.Controls.Add(this.vkilabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soyadtextBox);
            this.Controls.Add(this.guntextBox);
            this.Controls.Add(this.aytextBox);
            this.Controls.Add(this.yıltextBox);
            this.Controls.Add(this.boytextBox);
            this.Controls.Add(this.kgtextBox);
            this.Controls.Add(this.adtextBox);
            this.Controls.Add(this.kilolabel);
            this.Controls.Add(this.boylabel);
            this.Controls.Add(this.yılabel);
            this.Controls.Add(this.aylabel);
            this.Controls.Add(this.gunlabel);
            this.Controls.Add(this.soyadlabel);
            this.Controls.Add(this.adlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adlabel;
        private System.Windows.Forms.Label soyadlabel;
        private System.Windows.Forms.Label gunlabel;
        private System.Windows.Forms.Label aylabel;
        private System.Windows.Forms.Label yılabel;
        private System.Windows.Forms.Label boylabel;
        private System.Windows.Forms.Label kilolabel;
        private System.Windows.Forms.TextBox adtextBox;
        private System.Windows.Forms.TextBox kgtextBox;
        private System.Windows.Forms.TextBox boytextBox;
        private System.Windows.Forms.TextBox yıltextBox;
        private System.Windows.Forms.TextBox aytextBox;
        private System.Windows.Forms.TextBox guntextBox;
        private System.Windows.Forms.TextBox soyadtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vkilabel;
        private System.Windows.Forms.Label burclabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label vkiYorumlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

