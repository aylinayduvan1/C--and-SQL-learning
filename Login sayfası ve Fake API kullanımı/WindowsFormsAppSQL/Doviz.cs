using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsAppSQL
{
    public partial class Doviz : Form
    {

        public Doviz(string metin)
        {
            InitializeComponent();

        }

        public Doviz()
        {
            InitializeComponent();
        }

        private void lbSterlin_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            DovizGoster();
        }

        private void Doviz_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));

                lbDolar.Text = dolar.ToString();
                lbEuro.Text = euro.ToString();
                lbSterlin.Text = sterlin.ToString();
            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather();
            weather.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void alan_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void hava_btn_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather();
            weather.Show();
            this.Hide(); // Önceki formu kapat

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doviz_btn_Click(object sender, EventArgs e)
        {

        }

        private void Doviz_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Doviz_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Doviz_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }
    }
}
