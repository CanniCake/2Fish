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
    public partial class PrikazStanja : Form
    {
        public PrikazStanja()
        {
            InitializeComponent();
        }

        private void lblPrikaz_Click(object sender, EventArgs e)
        {

        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Pocetna2 p2 = new Pocetna2();
            this.Hide();
            p2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblPrint.Visible = true;
        }

        private void izvjestajBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.izvjestajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._2FishDataSet);

        }

        private void izvjestajBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this._2FishDataSet);

        }

        private void PrikazStanja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2FishDataSet.Ulov' table. You can move, or remove it, as needed.
            this.ulovTableAdapter.Fill(this._2FishDataSet.Ulov);
            // TODO: This line of code loads data into the '_2FishDataSet.Izvjestaj' table. You can move, or remove it, as needed.
            this.izvjestajTableAdapter.Fill(this._2FishDataSet.Izvjestaj);
            dateDatum.Format = DateTimePickerFormat.Custom;
            dateDatum.CustomFormat = "MMMM yyyy";
        }

        private void ulovDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
