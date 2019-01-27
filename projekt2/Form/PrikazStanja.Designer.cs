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
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.izvjestajTableAdapter = new projekt2._2FishDataSetTableAdapters.IzvjestajTableAdapter();
            this.tableAdapterManager = new projekt2._2FishDataSetTableAdapters.TableAdapterManager();
            this.ulovTableAdapter = new projekt2._2FishDataSetTableAdapters.UlovTableAdapter();
            this.ulovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdPrikaz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrikaz)).BeginInit();
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
            this.dateDatum.CustomFormat = "MMMM yyyy";
            this.dateDatum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDatum.Location = new System.Drawing.Point(150, 100);
            this.dateDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(187, 33);
            this.dateDatum.TabIndex = 5;
            this.dateDatum.Value = new System.DateTime(2019, 1, 27, 12, 6, 29, 0);
            this.dateDatum.ValueChanged += new System.EventHandler(this.dateDatum_ValueChanged);
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
            // ulovTableAdapter
            // 
            this.ulovTableAdapter.ClearBeforeFill = true;
            // 
            // grdPrikaz
            // 
            this.grdPrikaz.AllowUserToAddRows = false;
            this.grdPrikaz.AllowUserToDeleteRows = false;
            this.grdPrikaz.AllowUserToResizeColumns = false;
            this.grdPrikaz.AllowUserToResizeRows = false;
            this.grdPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrikaz.Location = new System.Drawing.Point(12, 154);
            this.grdPrikaz.Name = "grdPrikaz";
            this.grdPrikaz.ReadOnly = true;
            this.grdPrikaz.Size = new System.Drawing.Size(336, 170);
            this.grdPrikaz.TabIndex = 11;
            // 
            // PrikazStanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(360, 504);
            this.Controls.Add(this.grdPrikaz);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.lblPrikaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrikazStanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikazStanja";
            this.Load += new System.EventHandler(this.PrikazStanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrikaz)).EndInit();
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
        private _2FishDataSetTableAdapters.IzvjestajTableAdapter izvjestajTableAdapter;
        private _2FishDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _2FishDataSetTableAdapters.UlovTableAdapter ulovTableAdapter;
        private System.Windows.Forms.BindingSource ulovBindingSource;
        private System.Windows.Forms.DataGridView grdPrikaz;
    }
}