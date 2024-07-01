namespace Finanzas_personales
{
    partial class FrmAgregarTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarTipo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblIngresarTipo = new System.Windows.Forms.Label();
            this.txtIngresarTipo = new System.Windows.Forms.TextBox();
            this.btnAgregarTipo = new System.Windows.Forms.Button();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.llblEliminarTipo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblIngresarTipo);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 91);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Lime;
            this.btnCerrar.Location = new System.Drawing.Point(697, 20);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 52);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblIngresarTipo
            // 
            this.lblIngresarTipo.AutoSize = true;
            this.lblIngresarTipo.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarTipo.Location = new System.Drawing.Point(56, 36);
            this.lblIngresarTipo.Name = "lblIngresarTipo";
            this.lblIngresarTipo.Size = new System.Drawing.Size(274, 23);
            this.lblIngresarTipo.TabIndex = 4;
            this.lblIngresarTipo.Text = "Ingresar Tipo de Gasto";
            // 
            // txtIngresarTipo
            // 
            this.txtIngresarTipo.BackColor = System.Drawing.Color.Black;
            this.txtIngresarTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarTipo.ForeColor = System.Drawing.Color.Lime;
            this.txtIngresarTipo.Location = new System.Drawing.Point(37, 146);
            this.txtIngresarTipo.Name = "txtIngresarTipo";
            this.txtIngresarTipo.Size = new System.Drawing.Size(319, 30);
            this.txtIngresarTipo.TabIndex = 2;
            // 
            // btnAgregarTipo
            // 
            this.btnAgregarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipo.ForeColor = System.Drawing.Color.Lime;
            this.btnAgregarTipo.Location = new System.Drawing.Point(525, 139);
            this.btnAgregarTipo.Name = "btnAgregarTipo";
            this.btnAgregarTipo.Size = new System.Drawing.Size(128, 45);
            this.btnAgregarTipo.TabIndex = 5;
            this.btnAgregarTipo.Text = "Agregar";
            this.btnAgregarTipo.UseVisualStyleBackColor = true;
            this.btnAgregarTipo.Click += new System.EventHandler(this.btnAgregarTipo_Click);
            // 
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToOrderColumns = true;
            this.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTipo.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipo.GridColor = System.Drawing.Color.Black;
            this.dgvTipo.Location = new System.Drawing.Point(37, 248);
            this.dgvTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipo.RowHeadersVisible = false;
            this.dgvTipo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvTipo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTipo.RowTemplate.Height = 24;
            this.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo.Size = new System.Drawing.Size(698, 292);
            this.dgvTipo.TabIndex = 6;
            // 
            // llblEliminarTipo
            // 
            this.llblEliminarTipo.AutoSize = true;
            this.llblEliminarTipo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblEliminarTipo.ForeColor = System.Drawing.Color.Lime;
            this.llblEliminarTipo.Location = new System.Drawing.Point(33, 558);
            this.llblEliminarTipo.Name = "llblEliminarTipo";
            this.llblEliminarTipo.Size = new System.Drawing.Size(230, 23);
            this.llblEliminarTipo.TabIndex = 7;
            this.llblEliminarTipo.Text = "Eliminar Tipo de Gasto";
            this.llblEliminarTipo.Click += new System.EventHandler(this.llblEliminarTipo_Click);
            // 
            // FrmAgregarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.llblEliminarTipo);
            this.Controls.Add(this.dgvTipo);
            this.Controls.Add(this.btnAgregarTipo);
            this.Controls.Add(this.txtIngresarTipo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarTipo";
            this.Text = "FrmAgregarTipo";
            this.Load += new System.EventHandler(this.FrmAgregarTipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresarTipo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtIngresarTipo;
        private System.Windows.Forms.Button btnAgregarTipo;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.Label llblEliminarTipo;
    }
}