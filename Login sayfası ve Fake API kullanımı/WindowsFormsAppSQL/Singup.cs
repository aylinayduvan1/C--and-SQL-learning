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


namespace WindowsFormsAppSQL
{
    public partial class Singup : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Singup()
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

        private void Singup_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Singup_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

        private void Singup_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void singup_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Bilgi where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre ";
            con = new SqlConnection("server=DESKTOP-GABI42P\\SQLEXPRESS; Initial Catalog=Users; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@KullaniciAdi", nameadd_textBox.Text);
            cmd.Parameters.AddWithValue("@Sifre", addpas_textBox.Text);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Close(); // SqlDataReader'ı kapat
                con.Close(); // SqlConnection'ı kapat

                MessageBox.Show("Bu kullanıcı zaten mevcut!");
                return; // işlemi sonlandır
            }
            else
            {
                dr.Close(); // SqlDataReader'ı kapat

                string eklemeSorgusu = "INSERT INTO Bilgi (KullaniciAdi, Sifre) VALUES (@KullaniciAdi, @Sifre)";
                SqlCommand eklemeKomutu = new SqlCommand(eklemeSorgusu, con);
                eklemeKomutu.Parameters.AddWithValue("@KullaniciAdi", nameadd_textBox.Text);
                eklemeKomutu.Parameters.AddWithValue("@Sifre", addpas_textBox.Text);

                int affectedRows = eklemeKomutu.ExecuteNonQuery();

                con.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Veri başarıyla eklendi.");
                   nameadd_textBox.Text = "";
                    addpas_textBox.Text = "";
                }
            }
        }
    }
}
