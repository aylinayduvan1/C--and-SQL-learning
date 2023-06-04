using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Bilgi where KullaniciAdi=@user AND Sifre=@pass ";
            con = new SqlConnection("server=DESKTOP-GABI42P\\SQLEXPRESS; Initial Catalog=Users; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }

            else
            {

                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

            }
            con.Close();
          
        }
    }
}
