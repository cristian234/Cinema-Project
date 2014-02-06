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
    public partial class login_admin : Form
    {

        BusinessInterface _UserBus = new UserBUS();
        public login_admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(" Introduceti date in cele 2 campuri ");

            }
            else
            {
               string user = textBox1.Text;
               string pass = textBox2.Text;

               int status = _UserBus.CheckLoginBus(textBox1.Text, textBox2.Text);

               if (status == 1)
               {
                   Admin fab = new Admin();
                   fab.Show();

               }
            }
        }
    }
}
