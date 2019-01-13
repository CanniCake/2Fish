using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt2
{
    public partial class Pocetna1 : Form
    {
        public Pocetna1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Pocetna2 p2 = new Pocetna2();
            this.Hide();
            p2.ShowDialog();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Pocetna2 p2 = new Pocetna2();
            this.Hide();
            p2.ShowDialog();
        }
    }
}
