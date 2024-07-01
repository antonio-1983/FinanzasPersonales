namespace Finanzas_personales
{
    partial class FrmFinanzasPersonales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanzasPersonales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblImporteTotalIngresos = new System.Windows.Forms.Label();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.lblImporteOtrosIngresos = new System.Windows.Forms.Label();
            this.lblOtros = new System.Windows.Forms.Label();
            this.lblImporteSueldo = new System.Windows.Forms.Label();
            this.lblImporteGastos = new System.Windows.Forms.Label();
            this.lblImporteSaldo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblIngresarGasto = new System.Windows.Forms.Label();
            this.llblEliminarGasto = new System.Windows.Forms.Label();
            this.lblGenerarResumen = new System.Windows.Forms.Label();
            this.lblIngresarSueldo = new System.Windows.Forms.Label();
            this.lblIngresarOtrosIngresos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTituloGastos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Lime;
            this.btnCerrar.Location = new System.Drawing.Point(606, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 55);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Lime;
            this.lblMes.Location = new System.Drawing.Point(81, 19);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(117, 33);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "lblMes";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToOrderColumns = true;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.GridColor = System.Drawing.Color.Black;
            this.dgvDetalle.Location = new System.Drawing.Point(57, 145);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(590, 275);
            this.dgvDetalle.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(83, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(177, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL GASTOS";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.ForeColor = System.Drawing.Color.Lime;
            this.lblSueldo.Location = new System.Drawing.Point(83, 54);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(95, 23);
            this.lblSueldo.TabIndex = 3;
            this.lblSueldo.Text = "SUELDO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblImporteTotalIngresos);
            this.panel2.Controls.Add(this.lblTotalIngresos);
            this.panel2.Controls.Add(this.lblImporteOtrosIngresos);
            this.panel2.Controls.Add(this.lblOtros);
            this.panel2.Controls.Add(this.lblImporteSueldo);
            this.panel2.Controls.Add(this.lblImporteGastos);
            this.panel2.Controls.Add(this.lblSueldo);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Location = new System.Drawing.Point(-3, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 177);
            this.panel2.TabIndex = 4;
            // 
            // lblImporteTotalIngresos
            // 
            this.lblImporteTotalIngresos.AutoSize = true;
            this.lblImporteTotalIngresos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotalIngresos.ForeColor = System.Drawing.Color.Lime;
            this.lblImporteTotalIngresos.Location = new System.Drawing.Point(342, 134);
            this.lblImporteTotalIngresos.Name = "lblImporteTotalIngresos";
            this.lblImporteTotalIngresos.Size = new System.Drawing.Size(22, 23);
            this.lblImporteTotalIngresos.TabIndex = 12;
            this.lblImporteTotalIngresos.Text = "0";
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresos.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalIngresos.Location = new System.Drawing.Point(83, 134);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(196, 23);
            this.lblTotalIngresos.TabIndex = 11;
            this.lblTotalIngresos.Text = "TOTAL INGRESOS";
            // 
            // lblImporteOtrosIngresos
            // 
            this.lblImporteOtrosIngresos.AutoSize = true;
            this.lblImporteOtrosIngresos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteOtrosIngresos.ForeColor = System.Drawing.Color.Lime;
            this.lblImporteOtrosIngresos.Location = new System.Drawing.Point(342, 93);
            this.lblImporteOtrosIngresos.Name = "lblImporteOtrosIngresos";
            this.lblImporteOtrosIngresos.Size = new System.Drawing.Size(22, 23);
            this.lblImporteOtrosIngresos.TabIndex = 10;
            this.lblImporteOtrosIngresos.Text = "0";
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtros.ForeColor = System.Drawing.Color.Lime;
            this.lblOtros.Location = new System.Drawing.Point(83, 93);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(199, 23);
            this.lblOtros.TabIndex = 9;
            this.lblOtros.Text = "OTROS INGRESOS";
            // 
            // lblImporteSueldo
            // 
            this.lblImporteSueldo.AutoSize = true;
            this.lblImporteSueldo.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteSueldo.ForeColor = System.Drawing.Color.Lime;
            this.lblImporteSueldo.Location = new System.Drawing.Point(342, 54);
            this.lblImporteSueldo.Name = "lblImporteSueldo";
            this.lblImporteSueldo.Size = new System.Drawing.Size(0, 23);
            this.lblImporteSueldo.TabIndex = 7;
            // 
            // lblImporteGastos
            // 
            this.lblImporteGastos.AutoSize = true;
            this.lblImporteGastos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteGastos.ForeColor = System.Drawing.Color.Lime;
            this.lblImporteGastos.Location = new System.Drawing.Point(342, 15);
            this.lblImporteGastos.Name = "lblImporteGastos";
            this.lblImporteGastos.Size = new System.Drawing.Size(22, 23);
            this.lblImporteGastos.TabIndex = 6;
            this.lblImporteGastos.Text = "0";
            // 
            // lblImporteSaldo
            // 
            this.lblImporteSaldo.AutoSize = true;
            this.lblImporteSaldo.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteSaldo.ForeColor = System.Drawing.Color.Lime;
            this.lblImporteSaldo.Location = new System.Drawing.Point(342, 13);
            this.lblImporteSaldo.Name = "lblImporteSaldo";
            this.lblImporteSaldo.Size = new System.Drawing.Size(22, 23);
            this.lblImporteSaldo.TabIndex = 8;
            this.lblImporteSaldo.Text = "0";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Lime;
            this.lblSaldo.Location = new System.Drawing.Point(83, 13);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(82, 23);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "SALDO";
            // 
            // lblIngresarGasto
            // 
            this.lblIngresarGasto.AutoSize = true;
            this.lblIngresarGasto.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarGasto.ForeColor = System.Drawing.Color.Lime;
            this.lblIngresarGasto.Location = new System.Drawing.Point(81, 447);
            this.lblIngresarGasto.Name = "lblIngresarGasto";
            this.lblIngresarGasto.Size = new System.Drawing.Size(154, 23);
            this.lblIngresarGasto.TabIndex = 5;
            this.lblIngresarGasto.Text = "Ingresar Gasto";
            this.lblIngresarGasto.Click += new System.EventHandler(this.lblIngresarGasto_Click);
            // 
            // llblEliminarGasto
            // 
            this.llblEliminarGasto.AutoSize = true;
            this.llblEliminarGasto.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblEliminarGasto.ForeColor = System.Drawing.Color.Lime;
            this.llblEliminarGasto.Location = new System.Drawing.Point(447, 447);
            this.llblEliminarGasto.Name = "llblEliminarGasto";
            this.llblEliminarGasto.Size = new System.Drawing.Size(151, 23);
            this.llblEliminarGasto.TabIndex = 6;
            this.llblEliminarGasto.Text = "Eliminar Gasto";
            this.llblEliminarGasto.Click += new System.EventHandler(this.llblEliminarGasto_Click);
            // 
            // lblGenerarResumen
            // 
            this.lblGenerarResumen.AutoSize = true;
            this.lblGenerarResumen.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarResumen.ForeColor = System.Drawing.Color.Lime;
            this.lblGenerarResumen.Location = new System.Drawing.Point(493, 738);
            this.lblGenerarResumen.Name = "lblGenerarResumen";
            this.lblGenerarResumen.Size = new System.Drawing.Size(186, 23);
            this.lblGenerarResumen.TabIndex = 7;
            this.lblGenerarResumen.Text = "Generar Resumen";
            this.lblGenerarResumen.Click += new System.EventHandler(this.lblGenerarResumen_Click);
            // 
            // lblIngresarSueldo
            // 
            this.lblIngresarSueldo.AutoSize = true;
            this.lblIngresarSueldo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarSueldo.ForeColor = System.Drawing.Color.Lime;
            this.lblIngresarSueldo.Location = new System.Drawing.Point(287, 738);
            this.lblIngresarSueldo.Name = "lblIngresarSueldo";
            this.lblIngresarSueldo.Size = new System.Drawing.Size(162, 23);
            this.lblIngresarSueldo.TabIndex = 8;
            this.lblIngresarSueldo.Text = "Ingresar Sueldo";
            this.lblIngresarSueldo.Click += new System.EventHandler(this.lblIngresarSueldo_Click);
            // 
            // lblIngresarOtrosIngresos
            // 
            this.lblIngresarOtrosIngresos.AutoSize = true;
            this.lblIngresarOtrosIngresos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarOtrosIngresos.ForeColor = System.Drawing.Color.Lime;
            this.lblIngresarOtrosIngresos.Location = new System.Drawing.Point(19, 738);
            this.lblIngresarOtrosIngresos.Name = "lblIngresarOtrosIngresos";
            this.lblIngresarOtrosIngresos.Size = new System.Drawing.Size(241, 23);
            this.lblIngresarOtrosIngresos.TabIndex = 9;
            this.lblIngresarOtrosIngresos.Text = "Ingresar Otros Ingresos";
            this.lblIngresarOtrosIngresos.Click += new System.EventHandler(this.lblIngresarOtrosIngresos_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSaldo);
            this.panel3.Controls.Add(this.lblImporteSaldo);
            this.panel3.Location = new System.Drawing.Point(-3, 686);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 49);
            this.panel3.TabIndex = 10;
            // 
            // lblTituloGastos
            // 
            this.lblTituloGastos.AutoSize = true;
            this.lblTituloGastos.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGastos.ForeColor = System.Drawing.Color.Lime;
            this.lblTituloGastos.Location = new System.Drawing.Point(81, 96);
            this.lblTituloGastos.Name = "lblTituloGastos";
            this.lblTituloGastos.Size = new System.Drawing.Size(82, 23);
            this.lblTituloGastos.TabIndex = 11;
            this.lblTituloGastos.Text = "GASTOS";
            // 
            // FrmFinanzasPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 786);
            this.Controls.Add(this.lblTituloGastos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblIngresarOtrosIngresos);
            this.Controls.Add(this.lblIngresarSueldo);
            this.Controls.Add(this.lblGenerarResumen);
            this.Controls.Add(this.llblEliminarGasto);
            this.Controls.Add(this.lblIngresarGasto);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFinanzasPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finanzas personales";
            this.Load += new System.EventHandler(this.FrmFinanzasPersonales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblIngresarGasto;
        private System.Windows.Forms.Label llblEliminarGasto;
        private System.Windows.Forms.Label lblGenerarResumen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblIngresarSueldo;
        private System.Windows.Forms.Label lblImporteSueldo;
        private System.Windows.Forms.Label lblImporteGastos;
        private System.Windows.Forms.Label lblImporteSaldo;
        private System.Windows.Forms.Label lblImporteOtrosIngresos;
        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.Label lblIngresarOtrosIngresos;
        private System.Windows.Forms.Label lblImporteTotalIngresos;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTituloGastos;
    }
}

