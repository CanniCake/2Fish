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
    public partial class Pocetna2 : Form
    {
        public Pocetna2()
        {
            InitializeComponent();
        }

        string username;

        private void Pocetna2_Load(object sender, EventArgs e)
        {
            Pocetna1 p1 = new Pocetna1();
            p1.ShowDialog();
            username = p1.CurrentUser;

            lblWelcome.Text = "Welcome, " + username + "!";



        }

        internal static void show()
        {
         
        }

        private void Pocetna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            PrikazStanja Prikaz = new PrikazStanja();
            this.Hide();
            Prikaz.ShowDialog();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Form4 Unos_Ulova = new Form4();
            this.Hide();
            Unos_Ulova.ShowDialog();
        }

    }
}
