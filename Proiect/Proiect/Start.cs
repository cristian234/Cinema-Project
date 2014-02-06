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
        FilmeZi flm = new FilmeZi();

        public Start()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_admin fab = new login_admin();
            fab.Show();


                    
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Lunea ");
            flm.setDay(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Vinerea");
            flm.setDay(5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Martea");
            flm.setDay(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Miercurea ");
            flm.setDay(3);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Joia");
            flm.setDay(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Sambata ");
            flm.setDay(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Afisam filmele disponibile Duminica");
            flm.setDay(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }


    }
}
