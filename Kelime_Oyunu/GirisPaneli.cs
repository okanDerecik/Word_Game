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
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();

        private void button1_Click(object sender, EventArgs e)
        {
            LevelKolay fr = new LevelKolay();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fr.oyuncu = textBox1.Text;
                fr.Show();
                this.Hide();
            }

            //Oyuncu Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_GİRİS (AD) values (@p1)" ,bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
