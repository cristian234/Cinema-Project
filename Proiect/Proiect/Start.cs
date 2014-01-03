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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Lunea ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Vinerea");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Martea");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Miercurea ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Joia");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Sambata ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisam filmele disponibile Duminica");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
