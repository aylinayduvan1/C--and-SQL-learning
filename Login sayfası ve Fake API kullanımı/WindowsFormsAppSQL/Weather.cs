using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppSQL
{
    public partial class Weather : Form
    {

        public Weather()
        {
            InitializeComponent();
        }
        // https://openweathermap.org sitesinden kayıt olunarak bir alt satırdaki api kodu alınır
        private const string api = "b87d124450c2c1d68a146fceec3d1a63";
        // hava durumu bilgileri bir alt satırdaki web adresinden çekilecektir
        private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Turkey,Ankara&mode=xml&units=metric&APPID=" + api;

        private void Weather_Load(object sender, EventArgs e)
        {
            XDocument Hava = XDocument.Load(baglanti);
            var Sicaklik = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            lbSicaklik.Text = Sicaklik.ToString() + "°";

            //aşağıda yazılan kod satırları için bu siteden faydalanıyoruz.
            var Durum = Hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            lbHava.Text = Durum.ToString();

            if (Durum.Contains("clouds") == true)
            {
                pictureBox1.Visible = true;
            }
            if (Durum.Contains("clear sky") == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (Durum.Contains("sun") == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
        bool move;
        int mouse_x;
        int mouse_y;


        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void turn_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            this.Close(); // Önceki formu kapat

        }

        private void doviz_btn_Click(object sender, EventArgs e)
        {
            Kur kur = new Kur();
            kur.Show();
            this.Close(); // Önceki formu kapat

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Weather_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Weather_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }

        private void Weather_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }
    }
}
