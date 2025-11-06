namespace TPI_BDI_Grupo17
{
    partial class FormFedericoNavarrete
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
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpPeliculas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtTop1 = new System.Windows.Forms.RadioButton();
            this.rbtTop5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 174);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersVisible = false;
            this.dgvPeliculas.Size = new System.Drawing.Size(312, 264);
            this.dgvPeliculas.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Ejecutar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(122, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpPeliculas
            // 
            this.dtpPeliculas.CustomFormat = "yyyy";
            this.dtpPeliculas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeliculas.Location = new System.Drawing.Point(114, 25);
            this.dtpPeliculas.Name = "dtpPeliculas";
            this.dtpPeliculas.ShowUpDown = true;
            this.dtpPeliculas.Size = new System.Drawing.Size(131, 20);
            this.dtpPeliculas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro:";
            // 
            // rbtTop1
            // 
            this.rbtTop1.AutoSize = true;
            this.rbtTop1.Location = new System.Drawing.Point(55, 68);
            this.rbtTop1.Name = "rbtTop1";
            this.rbtTop1.Size = new System.Drawing.Size(53, 17);
            this.rbtTop1.TabIndex = 6;
            this.rbtTop1.TabStop = true;
            this.rbtTop1.Text = "Top 1";
            this.rbtTop1.UseVisualStyleBackColor = true;
            // 
            // rbtTop5
            // 
            this.rbtTop5.AutoSize = true;
            this.rbtTop5.Location = new System.Drawing.Point(114, 68);
            this.rbtTop5.Name = "rbtTop5";
            this.rbtTop5.Size = new System.Drawing.Size(55, 17);
            this.rbtTop5.TabIndex = 7;
            this.rbtTop5.TabStop = true;
            this.rbtTop5.Text = "Todos";
            this.rbtTop5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpPeliculas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtTop5);
            this.groupBox1.Controls.Add(this.rbtTop1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // FormFedericoNavarrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvPeliculas);
            this.Name = "FormFedericoNavarrete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtTop1;
        private System.Windows.Forms.RadioButton rbtTop5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}