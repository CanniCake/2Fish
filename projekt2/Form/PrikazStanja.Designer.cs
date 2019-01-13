namespace projekt2
{
    partial class PrikazStanja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazStanja));
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this._2FishDataSet = new projekt2._2FishDataSet();
            this.izvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izvjestajTableAdapter = new projekt2._2FishDataSetTableAdapters.IzvjestajTableAdapter();
            this.tableAdapterManager = new projekt2._2FishDataSetTableAdapters.TableAdapterManager();
            this.izvjestajBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.izvjestajBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ulovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulovTableAdapter = new projekt2._2FishDataSetTableAdapters.UlovTableAdapter();
            this.ulovDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._2FishDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingNavigator)).BeginInit();
            this.izvjestajBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Font = new System.Drawing.Font("Calibri", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblPrikaz.Location = new System.Drawing.Point(28, 20);
            this.lblPrikaz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(298, 64);
            this.lblPrikaz.TabIndex = 1;
            this.lblPrikaz.Text = "Prikaz Stanja";
            this.lblPrikaz.Click += new System.EventHandler(this.lblPrikaz_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblDatum.Location = new System.Drawing.Point(61, 105);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(76, 26);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Datum:";
            // 
            // dateDatum
            // 
            this.dateDatum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDatum.Location = new System.Drawing.Point(150, 100);
            this.dateDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(187, 33);
            this.dateDatum.TabIndex = 5;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnNatrag.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnNatrag.Location = new System.Drawing.Point(35, 409);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(131, 54);
            this.btnNatrag.TabIndex = 7;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnPrint.Location = new System.Drawing.Point(184, 409);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 54);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(209, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // lblPrint
            // 
            this.lblPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblPrint.Location = new System.Drawing.Point(187, 465);
            this.lblPrint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(128, 17);
            this.lblPrint.TabIndex = 10;
            this.lblPrint.Text = "You have no Printer :(";
            this.lblPrint.Visible = false;
            // 
            // _2FishDataSet
            // 
            this._2FishDataSet.DataSetName = "2FishDataSet";
            this._2FishDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izvjestajBindingSource
            // 
            this.izvjestajBindingSource.DataMember = "Izvjestaj";
            this.izvjestajBindingSource.DataSource = this._2FishDataSet;
            // 
            // izvjestajTableAdapter
            // 
            this.izvjestajTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IzvjestajTableAdapter = this.izvjestajTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.RibaTableAdapter = null;
            this.tableAdapterManager.UlovTableAdapter = this.ulovTableAdapter;
            this.tableAdapterManager.UpdateOrder = projekt2._2FishDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // izvjestajBindingNavigator
            // 
            this.izvjestajBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.izvjestajBindingNavigator.BindingSource = this.izvjestajBindingSource;
            this.izvjestajBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.izvjestajBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.izvjestajBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.izvjestajBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.izvjestajBindingNavigatorSaveItem});
            this.izvjestajBindingNavigator.Location = new System.Drawing.Point(28, 154);
            this.izvjestajBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.izvjestajBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.izvjestajBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.izvjestajBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.izvjestajBindingNavigator.Name = "izvjestajBindingNavigator";
            this.izvjestajBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.izvjestajBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.izvjestajBindingNavigator.TabIndex = 11;
            this.izvjestajBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // izvjestajBindingNavigatorSaveItem
            // 
            this.izvjestajBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.izvjestajBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("izvjestajBindingNavigatorSaveItem.Image")));
            this.izvjestajBindingNavigatorSaveItem.Name = "izvjestajBindingNavigatorSaveItem";
            this.izvjestajBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.izvjestajBindingNavigatorSaveItem.Text = "Save Data";
            this.izvjestajBindingNavigatorSaveItem.Click += new System.EventHandler(this.izvjestajBindingNavigatorSaveItem_Click_1);
            // 
            // ulovBindingSource
            // 
            this.ulovBindingSource.DataMember = "Ulov";
            this.ulovBindingSource.DataSource = this._2FishDataSet;
            // 
            // ulovTableAdapter
            // 
            this.ulovTableAdapter.ClearBeforeFill = true;
            // 
            // ulovDataGridView
            // 
            this.ulovDataGridView.AutoGenerateColumns = false;
            this.ulovDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ulovDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ulovDataGridView.DataSource = this.ulovBindingSource;
            this.ulovDataGridView.Location = new System.Drawing.Point(51, 182);
            this.ulovDataGridView.Name = "ulovDataGridView";
            this.ulovDataGridView.Size = new System.Drawing.Size(246, 196);
            this.ulovDataGridView.TabIndex = 11;
            this.ulovDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ulovDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_LOVA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_LOVA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Ribe";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Ribe";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // PrikazStanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(360, 504);
            this.Controls.Add(this.ulovDataGridView);
            this.Controls.Add(this.izvjestajBindingNavigator);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.lblPrikaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrikazStanja";
            this.Text = "PrikazStanja";
            this.Load += new System.EventHandler(this.PrikazStanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this._2FishDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingNavigator)).EndInit();
            this.izvjestajBindingNavigator.ResumeLayout(false);
            this.izvjestajBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrint;
        private _2FishDataSet _2FishDataSet;
        private System.Windows.Forms.BindingSource izvjestajBindingSource;
        private _2FishDataSetTableAdapters.IzvjestajTableAdapter izvjestajTableAdapter;
        private _2FishDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator izvjestajBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton izvjestajBindingNavigatorSaveItem;
        private _2FishDataSetTableAdapters.UlovTableAdapter ulovTableAdapter;
        private System.Windows.Forms.BindingSource ulovBindingSource;
        private System.Windows.Forms.DataGridView ulovDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}