using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace projekt2
{
    public partial class Pocetna1 : Form
    {
        public Pocetna1()
        {
            InitializeComponent();
        }

        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataReader DR;
        public string CurrentUser;
        string connectionString = "URI=file:Baza.db";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Set Connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection(connectionString);
        }


        //Authentication
        private void checkAccount(string user)
        {
            SetConnection();
            sql_cmd = new SQLiteCommand();
            sql_con.Open();

            int count = 0;
            string query = @"SELECT ID_KORISNIK, Password FROM Korisnik where ID_KORISNIK ='" + user + "'";
            sql_cmd.CommandText = query;
            sql_cmd.Connection = sql_con;
            DR = sql_cmd.ExecuteReader();
            while (DR.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Account already Created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (count == 0)
            {
                insertData(txtUser.Text, txtPW.Text);
            }


        }

        private void insertData(string username, string password)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = new SQLiteCommand();
            string query = @"INSERT INTO Korisnik(ID_KORISNIK, Password) VALUES (@username, @password)";
            sql_cmd.CommandText = query;
            sql_cmd.Connection = sql_con;
            sql_cmd.Parameters.Add(new SQLiteParameter("@username", username));
            sql_cmd.Parameters.Add(new SQLiteParameter("@password", password));
            sql_cmd.ExecuteNonQuery();

            MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AuthenticateAccount(string username, string password)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = new SQLiteCommand();
            string query = @"SELECT ID_KORISNIK, Password FROM Korisnik WHERE ID_KORISNIK='" + username + "' AND Password = '" + password + "'";

            int count = 0;
            sql_cmd.CommandText = query;
            sql_cmd.Connection = sql_con;

            DR = sql_cmd.ExecuteReader();
            while (DR.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MessageBox.Show("Login Successful!", "Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentUser = username;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != string.Empty 
                && txtPW.Text != string.Empty)
            {
                AuthenticateAccount(txtUser.Text, txtPW.Text);
            }        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != string.Empty
                && txtPW.Text != string.Empty)
            {
                checkAccount(txtUser.Text);
            }
        }

    }
}
