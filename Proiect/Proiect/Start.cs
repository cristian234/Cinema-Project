using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                //aici trebe sa facem search-ul

                //trebe sa gandim totusi si un modul in care sa avem o lista cu filme, exact ca la light cinemas ...


            }
            else
            {
                MessageBox.Show("Introduceti filmul pe care doriti sa il cautati ! ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOON ! private :)");
        }
    }
}
