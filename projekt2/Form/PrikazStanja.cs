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
    public partial class PrikazStanja : Form
    {
        public PrikazStanja()
        {
            InitializeComponent();
        }

        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        SQLiteDataAdapter DB;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string connectionString = "URI=file:Baza.db";

        public String rdt;

        public string username = Pocetna2.username;

        private void LoadData()
        {
            sql_con = new SQLiteConnection(connectionString);
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT Ulov.ID_Riba, Vrsta, Težina FROM Ulov INNER JOIN Riba on Ulov.ID_Riba = Riba.ID_RIBA INNER JOIN Izvjestaj on Ulov.ID_ULOV = Izvjestaj.ID_Ulov WHERE Izvjestaj.ID_Korisnik = '" + username + "' AND Izvjestaj.Datum = '" + rdt + "'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            DB.Fill(ds, "Info");
            grdPrikaz.DataSource = ds.Tables[0];
            sql_con.Close();
        }

        private void PrikazStanja_Load(object sender, EventArgs e)
        {
            dateDatum.Format = DateTimePickerFormat.Custom;
            dateDatum.CustomFormat = "MMMM yyyy";
            rdt = dateDatum.Value.ToString("MMMM yyyy");

            LoadData();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateDatum_ValueChanged(object sender, EventArgs e)
        {
            rdt = dateDatum.Value.ToString("MMMM yyyy");
            LoadData();

        }
    }
}
