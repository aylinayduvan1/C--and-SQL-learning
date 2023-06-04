using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private string veri;
        public Form2(string veri)
        {
            InitializeComponent();
            this.veri = veri;
            label3.Text = veri; // Veriyi bir etiket kontrolünde görü
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
