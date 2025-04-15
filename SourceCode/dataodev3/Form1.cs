using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dataodev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       //   static string constring = "Data Source=LAPTOP-PM5A38PG\\SQLEXPRESS;Initial Catalog = Kisiler; Integrated Security = True; Trust Server Certificate=True";
            static string constring = "Data Source=LAPTOP-PM5A38PG\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True;TrustServerCertificate=True;";

        SqlConnection connect = new SqlConnection(constring);

        string ad, soyad, ay;
        int boy, yil;
        float kg;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into bilgi (ad,soyad,dogum_gun,dogum_ay,dogum_yil,kilo,boy) values(@ad,@soyad,@gun,@ay,@yil,@kilo,@boy)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@ad", adtextBox.Text);
                komut.Parameters.AddWithValue("@soyad", soyadtextBox.Text);
                komut.Parameters.AddWithValue("@ay",int.Parse( aytextBox.Text));
                komut.Parameters.AddWithValue("@gun", int.Parse(guntextBox.Text));
                komut.Parameters.AddWithValue("@yil", int.Parse(yıltextBox.Text));
                komut.Parameters.AddWithValue("@kilo", float.Parse(kgtextBox.Text));  
                komut.Parameters.AddWithValue("@boy", int.Parse(boytextBox.Text));   

                int rowsAffected = komut.ExecuteNonQuery();



                connect.Close();
                MessageBox.Show("Kayıt Eklendi");

                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi", hata.Message); 
            }

            float kilo = float.Parse(kgtextBox.Text);
            float boyMetre = int.Parse(boytextBox.Text) / 100f; 
            float vki = kilo / (boyMetre * boyMetre);

            vkilabel.Text= vki.ToString();

            string yorum = "";

            if (vki < 18.5)
            {
                yorum = "Zayıf";
               
            }
            else if (vki >= 18.5 && vki < 25)
            {
                yorum = "Normal (Sağlıklı)";
               
            }
            else if (vki >= 25 && vki < 30)
            {
                yorum = "Fazla Kilolu";
               
            }
            else if (vki >= 30 && vki < 35)
            {
                yorum = "1. Derece Obez";
                
            }
            else if (vki >= 35 && vki < 40)
            {
                yorum = "2. Derece Obez";
               
            }
            else
            {
                yorum = "Morbid Obez (Aşırı)";
               
            }

           
            vkiYorumlabel.Text = yorum;

            int gun = int.Parse(guntextBox.Text);
            int ay = int.Parse(aytextBox.Text);

            string burc = "";

            switch (ay)
            {
                case 1: burc = (gun <= 20) ? "Oğlak" : "Kova"; break;
                case 2: burc = (gun <= 19) ? "Kova" : "Balık"; break;
                case 3: burc = (gun <= 20) ? "Balık" : "Koç"; break;
                case 4: burc = (gun <= 20) ? "Koç" : "Boğa"; break;
                case 5: burc = (gun <= 21) ? "Boğa" : "İkizler"; break;
                case 6: burc = (gun <= 21) ? "İkizler" : "Yengeç"; break;
                case 7: burc = (gun <= 22) ? "Yengeç" : "Aslan"; break;
                case 8: burc = (gun <= 23) ? "Aslan" : "Başak"; break;
                case 9: burc = (gun <= 23) ? "Başak" : "Terazi"; break;
                case 10: burc = (gun <= 23) ? "Terazi" : "Akrep"; break;
                case 11: burc = (gun <= 22) ? "Akrep" : "Yay"; break;
                case 12: burc = (gun <= 21) ? "Yay" : "Oğlak"; break;
            }

            burclabel.Text =  burc;

           

            // Burç resmini Resources içinden PictureBox'a yükle
            switch (burc)
            {
                case "Koç":
                    pictureBox1.Image = Properties.Resources.koc;
                    break;
                case "Boğa":
                    pictureBox1.Image = Properties.Resources.boga;
                    break;
                case "İkizler":
                    pictureBox1.Image = Properties.Resources.ikizler;
                    break;
                case "Yengeç":
                    pictureBox1.Image = Properties.Resources.yengec;
                    break;
                case "Aslan":
                    pictureBox1.Image = Properties.Resources.aslan;
                    break;
                case "Başak":
                    pictureBox1.Image = Properties.Resources.basak;
                    break;
                case "Terazi":
                    pictureBox1.Image = Properties.Resources.terazi;
                    break;
                case "Akrep":
                    pictureBox1.Image = Properties.Resources.akrep;
                    break;
                case "Yay":
                    pictureBox1.Image = Properties.Resources.yay;
                    break;
                case "Oğlak":
                    pictureBox1.Image = Properties.Resources.oglak;
                    break;
                case "Kova":
                    pictureBox1.Image = Properties.Resources.kova;
                    break;
                case "Balık":
                    pictureBox1.Image = Properties.Resources.balik;
                    break;
            }







        }
    }
}
