namespace Finanzas_personales
{
    partial class FrmAgregarOtrosIngresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarOtrosIngresos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAgregarOtrosIngresos = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnAgregarOtrosIngresos = new System.Windows.Forms.Button();
            this.dgvOtrosIngresos = new System.Windows.Forms.DataGridView();
            this.lblGenerarResumenIngresosExtras = new System.Windows.Forms.Label();
            this.llblEliminarOtrosIngresos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtrosIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblAgregarOtrosIngresos);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 75);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Lime;
            this.btnCerrar.Location = new System.Drawing.Point(669, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 55);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAgregarOtrosIngresos
            // 
            this.lblAgregarOtrosIngresos.AutoSize = true;
            this.lblAgregarOtrosIngresos.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarOtrosIngresos.ForeColor = System.Drawing.Color.Lime;
            this.lblAgregarOtrosIngresos.Location = new System.Drawing.Point(35, 19);
            this.lblAgregarOtrosIngresos.Name = "lblAgregarOtrosIngresos";
            this.lblAgregarOtrosIngresos.Size = new System.Drawing.Size(389, 33);
            this.lblAgregarOtrosIngresos.TabIndex = 0;
            this.lblAgregarOtrosIngresos.Text = "Agregar Otros Ingresos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Lime;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 22);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Black;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Lime;
            this.txtDescripcion.Location = new System.Drawing.Point(223, 106);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(319, 30);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.Color.Lime;
            this.lblImporte.Location = new System.Drawing.Point(36, 177);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(69, 22);
            this.lblImporte.TabIndex = 6;
            this.lblImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.Black;
            this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.Lime;
            this.txtImporte.Location = new System.Drawing.Point(223, 169);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(319, 30);
            this.txtImporte.TabIndex = 7;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // btnAgregarOtrosIngresos
            // 
            this.btnAgregarOtrosIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarOtrosIngresos.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOtrosIngresos.ForeColor = System.Drawing.Color.Lime;
            this.btnAgregarOtrosIngresos.Location = new System.Drawing.Point(40, 246);
            this.btnAgregarOtrosIngresos.Name = "btnAgregarOtrosIngresos";
            this.btnAgregarOtrosIngresos.Size = new System.Drawing.Size(128, 45);
            this.btnAgregarOtrosIngresos.TabIndex = 8;
            this.btnAgregarOtrosIngresos.Text = "Agregar";
            this.btnAgregarOtrosIngresos.UseVisualStyleBackColor = true;
            this.btnAgregarOtrosIngresos.Click += new System.EventHandler(this.btnAgregarOtrosIngresos_Click);
            // 
            // dgvOtrosIngresos
            // 
            this.dgvOtrosIngresos.AllowUserToOrderColumns = true;
            this.dgvOtrosIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOtrosIngresos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvOtrosIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOtrosIngresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOtrosIngresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOtrosIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOtrosIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOtrosIngresos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOtrosIngresos.GridColor = System.Drawing.Color.Black;
            this.dgvOtrosIngresos.Location = new System.Drawing.Point(36, 306);
            this.dgvOtrosIngresos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOtrosIngresos.Name = "dgvOtrosIngresos";
            this.dgvOtrosIngresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOtrosIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOtrosIngresos.RowHeadersVisible = false;
            this.dgvOtrosIngresos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvOtrosIngresos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOtrosIngresos.RowTemplate.Height = 24;
            this.dgvOtrosIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOtrosIngresos.Size = new System.Drawing.Size(707, 241);
            this.dgvOtrosIngresos.TabIndex = 9;
            // 
            // lblGenerarResumenIngresosExtras
            // 
            this.lblGenerarResumenIngresosExtras.AutoSize = true;
            this.lblGenerarResumenIngresosExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarResumenIngresosExtras.ForeColor = System.Drawing.Color.Lime;
            this.lblGenerarResumenIngresosExtras.Location = new System.Drawing.Point(36, 563);
            this.lblGenerarResumenIngresosExtras.Name = "lblGenerarResumenIngresosExtras";
            this.lblGenerarResumenIngresosExtras.Size = new System.Drawing.Size(157, 22);
            this.lblGenerarResumenIngresosExtras.TabIndex = 10;
            this.lblGenerarResumenIngresosExtras.Text = "Generar Resumen";
            this.lblGenerarResumenIngresosExtras.Click += new System.EventHandler(this.lblGenerarResumenIngresosExtras_Click);
            // 
            // llblEliminarOtrosIngresos
            // 
            this.llblEliminarOtrosIngresos.AutoSize = true;
            this.llblEliminarOtrosIngresos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblEliminarOtrosIngresos.ForeColor = System.Drawing.Color.Lime;
            this.llblEliminarOtrosIngresos.Location = new System.Drawing.Point(657, 563);
            this.llblEliminarOtrosIngresos.Name = "llblEliminarOtrosIngresos";
            this.llblEliminarOtrosIngresos.Size = new System.Drawing.Size(86, 23);
            this.llblEliminarOtrosIngresos.TabIndex = 11;
            this.llblEliminarOtrosIngresos.Text = "Eliminar";
            this.llblEliminarOtrosIngresos.Click += new System.EventHandler(this.llblEliminarOtrosIngresos_Click);
            // 
            // FrmAgregarOtrosIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.llblEliminarOtrosIngresos);
            this.Controls.Add(this.lblGenerarResumenIngresosExtras);
            this.Controls.Add(this.dgvOtrosIngresos);
            this.Controls.Add(this.btnAgregarOtrosIngresos);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarOtrosIngresos";
            this.Text = "FrmAgregarOtrosIngresos";
            this.Load += new System.EventHandler(this.FrmAgregarOtrosIngresos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtrosIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblAgregarOtrosIngresos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnAgregarOtrosIngresos;
        private System.Windows.Forms.DataGridView dgvOtrosIngresos;
        private System.Windows.Forms.Label lblGenerarResumenIngresosExtras;
        private System.Windows.Forms.Label llblEliminarOtrosIngresos;
    }
}