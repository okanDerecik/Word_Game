using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kelime_Oyunu
{
    public partial class LevelNormal : Form
    {
        public LevelNormal()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();

        public string oyuncu;
        int sure = 60;
        int dogru = 0;
        int yanlis = 0;
        int pas = 0;
        int sayi = 1;

        void sorugetir()
        {

            SqlCommand komut = new SqlCommand("Select * from TBL_NORMAL where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtEnglish.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            bgl.baglanti().Close();
        }

        private void LevelNormal_Load(object sender, EventArgs e)
        {
            LblOyuncu.Text = oyuncu;
            sorugetir();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtTurkish.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                sayi++;
                sorugetir();
                TxtTurkish.Clear();
            }
            else if (TxtTurkish.Text == "")
            {
                MessageBox.Show("Lütfen pas butonuna tıklayınız");
            }

            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                sayi++;
                sorugetir();
                TxtTurkish.Clear();
            }

            if (sayi == 16)
            {
                if (dogru == 15)
                {
                    MessageBox.Show("Tebrikler Yeni Bölüme Yönlendiriliyorsunuz");
                    LevelZor fr = new LevelZor();
                    fr.Show();
                    this.Hide();
                }
                else if (yanlis >= 1 && pas >= 1)
                {
                    MessageBox.Show("Bölümü Geçemediniz tekrar deneyiniz.");
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtTurkish.Text == "")
            {
                pas++;
                LblPas.Text = pas.ToString();
                sayi++;
                sorugetir();
                TxtTurkish.Clear();
            }
            if (sayi == 15)
            {
                if (pas >= 1)
                {
                    MessageBox.Show("Bölümü Geçemediniz tekrar deneyiniz.");
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                TxtTurkish.Enabled = false;
                TxtEnglish.Enabled = false;
                MessageBox.Show("Maalesef Oyunu Bitiremediniz. Tekrar Deneyiniz.");
                timer1.Stop();
            }
        }
    }
}
