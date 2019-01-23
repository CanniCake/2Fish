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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string username;


        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataAdapter DB;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string connectionString = "URI=file:Baza.db";



        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
        }


        //Set Connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection(connectionString);
        }

        //Set ExecuteQuery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT ID_Riba, Težina FROM Ulov";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            DB.Fill(ds, "Info");
            grdUnos.DataSource = ds.Tables[0];
            sql_con.Close();
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
                string txtQuery = "insert into Ulov (ID_Riba, Težina)values('" + cmbUnosRiba.Text + "','" + txtUnosTezina.Text + "')";
                ExecuteQuery(txtQuery);

                //string txtIzvj = "insert into Izvještaj (ID_Ulov, ID_Korisnik, Datum) values('" + last_insert_rowid() + "','" + username + "','" + DateTime.Now + "')";
                //ExecuteQuery(txtIzvj);
                LoadData();            
        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Ulov where ID_Riba ='" + cmbUnosRiba.Text + "' AND Težina = '" + txtUnosTezina.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        //Grid Select on Click
        private void grdUnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdUnos.Rows[e.RowIndex];
                cmbUnosRiba.Text = row.Cells["ID_Riba"].Value.ToString();
                txtUnosTezina.Text = row.Cells["Težina"].Value.ToString();
                //cmbUnosRiba.Text = grdUnos.SelectedRows[0].Cells[0].Value.ToString();
                //txtUnosTezina.Text = grdUnos.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
