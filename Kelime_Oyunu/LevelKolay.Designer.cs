namespace Kelime_Oyunu
{
    partial class LevelKolay
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOyuncu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEnglish = new System.Windows.Forms.TextBox();
            this.TxtTurkish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.LblPas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 222;
            this.label1.Text = "Oyuncu :";
            // 
            // LblOyuncu
            // 
            this.LblOyuncu.AutoSize = true;
            this.LblOyuncu.Location = new System.Drawing.Point(175, 70);
            this.LblOyuncu.Name = "LblOyuncu";
            this.LblOyuncu.Size = new System.Drawing.Size(46, 23);
            this.LblOyuncu.TabIndex = 202;
            this.LblOyuncu.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 200;
            this.label3.Text = "İngilizce :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Türkçe :";
            // 
            // TxtEnglish
            // 
            this.TxtEnglish.Enabled = false;
            this.TxtEnglish.Location = new System.Drawing.Point(199, 148);
            this.TxtEnglish.Name = "TxtEnglish";
            this.TxtEnglish.Size = new System.Drawing.Size(195, 29);
            this.TxtEnglish.TabIndex = 4;
            // 
            // TxtTurkish
            // 
            this.TxtTurkish.Location = new System.Drawing.Point(199, 202);
            this.TxtTurkish.Name = "TxtTurkish";
            this.TxtTurkish.Size = new System.Drawing.Size(195, 29);
            this.TxtTurkish.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Süre :";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Location = new System.Drawing.Point(514, 99);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(33, 23);
            this.LblSure.TabIndex = 7;
            this.LblSure.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doğru :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yanlış :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pas :";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Location = new System.Drawing.Point(526, 154);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(22, 23);
            this.LblDogru.TabIndex = 11;
            this.LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(525, 202);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(22, 23);
            this.LblYanlis.TabIndex = 12;
            this.LblYanlis.Text = "0";
            // 
            // LblPas
            // 
            this.LblPas.AutoSize = true;
            this.LblPas.Location = new System.Drawing.Point(525, 252);
            this.LblPas.Name = "LblPas";
            this.LblPas.Size = new System.Drawing.Size(22, 23);
            this.LblPas.TabIndex = 13;
            this.LblPas.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "CEVAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Location = new System.Drawing.Point(478, 312);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(69, 23);
            this.LblCevap.TabIndex = 34;
            this.LblCevap.Text = "label12";
            this.LblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Boş Bırakmak İçin Boş Şekilde Cevaplaya Tıklayınız";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "PAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LevelKolay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(653, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPas);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTurkish);
            this.Controls.Add(this.TxtEnglish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblOyuncu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LevelKolay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelKolay";
            this.Load += new System.EventHandler(this.LevelKolay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblOyuncu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEnglish;
        private System.Windows.Forms.TextBox TxtTurkish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Label LblPas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}