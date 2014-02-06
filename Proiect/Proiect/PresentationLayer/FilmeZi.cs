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
    public partial class FilmeZi : Form
    {
        private int Zi;
        BusinessInterface _UserBus = new UserBUS();
        public FilmeZi()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void FilmeZi_Load(object sender, EventArgs e)
        {

        }

        public void setDay(int zi)
        {
            Zi = zi;
            Filme.DataSource = _UserBus.FilmeZi(zi);
            this.Visible = true;
        }



        private void Filme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
