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

        private void PrikazStanja_Load(object sender, EventArgs e)
        {
            dateDatum.Format = DateTimePickerFormat.Custom;
            dateDatum.CustomFormat = "MMMM yyyy";

            sql_con = new SQLiteConnection(connectionString);
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT ID_Riba, Težina FROM Ulov";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            DB.Fill(ds, "Info");
            grdPrikaz.DataSource = ds.Tables[0];
            sql_con.Close();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
