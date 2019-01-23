namespace projekt2
{
    partial class Form4
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
            this.lblUnos = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new projekt2._2FishDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new projekt2._2FishDataSetTableAdapters.TableAdapterManager();
            this.ulovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulovTableAdapter = new projekt2._2FishDataSetTableAdapters.UlovTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grdUnos = new System.Windows.Forms.DataGridView();
            this.lblUnosRiba = new System.Windows.Forms.Label();
            this.lblUnosTezina = new System.Windows.Forms.Label();
            this.txtUnosTezina = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbUnosRiba = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnos
            // 
            this.lblUnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUnos.AutoSize = true;
            this.lblUnos.Font = new System.Drawing.Font("Calibri", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblUnos.Location = new System.Drawing.Point(40, 21);
            this.lblUnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(267, 64);
            this.lblUnos.TabIndex = 0;
            this.lblUnos.Text = "Unos ulova";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 90);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 33);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 21, 4, 36, 53, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblDatum.Location = new System.Drawing.Point(61, 95);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(76, 26);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnUnesi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnUnesi.Location = new System.Drawing.Point(118, 423);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(131, 54);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IzvjestajTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.RibaTableAdapter = null;
            this.tableAdapterManager.UlovTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projekt2._2FishDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ulovTableAdapter
            // 
            this.ulovTableAdapter.ClearBeforeFill = true;
            // 
            // grdUnos
            // 
            this.grdUnos.AllowUserToResizeColumns = false;
            this.grdUnos.AllowUserToResizeRows = false;
            this.grdUnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnos.Location = new System.Drawing.Point(51, 214);
            this.grdUnos.Name = "grdUnos";
            this.grdUnos.ReadOnly = true;
            this.grdUnos.Size = new System.Drawing.Size(256, 192);
            this.grdUnos.TabIndex = 5;
            this.grdUnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUnos_CellClick);
            // 
            // lblUnosRiba
            // 
            this.lblUnosRiba.AutoSize = true;
            this.lblUnosRiba.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblUnosRiba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblUnosRiba.Location = new System.Drawing.Point(61, 134);
            this.lblUnosRiba.Name = "lblUnosRiba";
            this.lblUnosRiba.Size = new System.Drawing.Size(94, 26);
            this.lblUnosRiba.TabIndex = 6;
            this.lblUnosRiba.Text = "Šifra ribe:";
            // 
            // lblUnosTezina
            // 
            this.lblUnosTezina.AutoSize = true;
            this.lblUnosTezina.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblUnosTezina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblUnosTezina.Location = new System.Drawing.Point(50, 172);
            this.lblUnosTezina.Name = "lblUnosTezina";
            this.lblUnosTezina.Size = new System.Drawing.Size(105, 26);
            this.lblUnosTezina.TabIndex = 7;
            this.lblUnosTezina.Text = "Težina(KG):";
            // 
            // txtUnosTezina
            // 
            this.txtUnosTezina.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtUnosTezina.Location = new System.Drawing.Point(180, 169);
            this.txtUnosTezina.Name = "txtUnosTezina";
            this.txtUnosTezina.Size = new System.Drawing.Size(87, 33);
            this.txtUnosTezina.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(272, 133);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(272, 170);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbUnosRiba
            // 
            this.cmbUnosRiba.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cmbUnosRiba.FormattingEnabled = true;
            this.cmbUnosRiba.Items.AddRange(new object[] {
            "AHH",
            "ALB",
            "AMB",
            "ANE",
            "ANN",
            "ATB",
            "BBS",
            "BFT",
            "BLU",
            "BOG",
            "BON",
            "BPI",
            "BRB",
            "BSS",
            "CBM",
            "CBR",
            "COB",
            "COE",
            "CTB",
            "DEC",
            "DEP",
            "DOL",
            "ELE",
            "FOX",
            "FRZ",
            "GAR",
            "GAS",
            "GPX",
            "GUX",
            "HKE",
            "HMM",
            "HOM",
            "JAX",
            "JOD",
            "LEE",
            "LEZ",
            "LTA",
            "MAC",
            "MGR",
            "MMH",
            "MNZ",
            "MSP",
            "MUE",
            "MUL",
            "MUR",
            "MUT",
            "MZZ",
            "PAC",
            "PIC",
            "PIL",
            "PLZ",
            "RPG",
            "RSE",
            "SAA",
            "SBA",
            "SBG",
            "SBR",
            "SBS",
            "SFS",
            "SHR",
            "SLM",
            "SOL",
            "SPC",
            "SPR",
            "SSB",
            "SWA",
            "SWO",
            "TUR",
            "UUC",
            "VMA",
            "WEX",
            "WHB",
            "WHG",
            "WRM",
            "YRS"});
            this.cmbUnosRiba.Location = new System.Drawing.Point(180, 131);
            this.cmbUnosRiba.Name = "cmbUnosRiba";
            this.cmbUnosRiba.Size = new System.Drawing.Size(87, 34);
            this.cmbUnosRiba.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(360, 504);
            this.Controls.Add(this.cmbUnosRiba);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUnosTezina);
            this.Controls.Add(this.lblUnosTezina);
            this.Controls.Add(this.lblUnosRiba);
            this.Controls.Add(this.grdUnos);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblUnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private _2FishDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private _2FishDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource ulovBindingSource;
        private _2FishDataSetTableAdapters.UlovTableAdapter ulovTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView grdUnos;
        private System.Windows.Forms.Label lblUnosRiba;
        private System.Windows.Forms.Label lblUnosTezina;
        private System.Windows.Forms.TextBox txtUnosTezina;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbUnosRiba;
    }
}