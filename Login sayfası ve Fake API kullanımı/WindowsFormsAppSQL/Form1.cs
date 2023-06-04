using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace WindowsFormsAppSQL
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        bool move;
        int mouse_x;
        int mouse_y;

       
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Bilgi where KullaniciAdi=@user AND Sifre=@pass ";
            con = new SqlConnection("server=DESKTOP-GABI42P\\SQLEXPRESS; Initial Catalog=Users; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", name_textBox.Text);
            cmd.Parameters.AddWithValue("@pass", password_textBox.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
                HomePage homepage = new HomePage();
                homepage.gveri = name_textBox.Text;
                homepage.ShowDialog();
                this.Hide();

            }

            else
            {

                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

            }
            con.Close();
        }

        private void sing_btn_Click(object sender, EventArgs e)
        {
            Singup singup = new Singup();
            singup.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
