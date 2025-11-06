namespace TPI_BDI_Grupo17
{
    partial class FormTomasLiendo
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
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(48, 43);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(90, 16);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Fecha desde:";
            this.lblFechaDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(55, 82);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(84, 16);
            this.lblFechaHasta.TabIndex = 1;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(160, 38);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDesde.TabIndex = 2;
            this.dtpFechaDesde.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(160, 82);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHasta.TabIndex = 3;
            this.dtpFechaHasta.Value = new System.DateTime(2025, 11, 5, 14, 1, 4, 0);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(380, 37);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AllowUserToResizeColumns = false;
            this.dgvResultados.AllowUserToResizeRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultados.Location = new System.Drawing.Point(0, 134);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(867, 334);
            this.dgvResultados.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(835, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormTomasLiendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 468);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResultados);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTomasLiendo";
            this.Text = "411994, Tomás Liendo";
            this.Load += new System.EventHandler(this.FormTomasLiendo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}