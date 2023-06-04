using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppSQL
{
    public partial class HomePage : Form
    {
        public string gveri;
        


        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            label1.Text = gveri;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = gveri;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kur kur = new Kur();
            kur.Show();
            this.Close(); // Önceki formu kapat


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather();
            weather.Show();
            this.Close(); // Önceki formu kapat

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void HomePage_MouseUp(object sender, MouseEventArgs e)
        {
            move= false;
        }

        private void HomePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

        private void turn_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            this.Close(); // Önceki formu kapat
        }
    }
}
