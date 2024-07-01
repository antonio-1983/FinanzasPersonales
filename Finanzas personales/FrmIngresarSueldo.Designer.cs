namespace Finanzas_personales
{
    partial class FrmIngresarSueldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresarSueldo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIngresarSueldo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtIngresarSueldo = new System.Windows.Forms.TextBox();
            this.btnAgregarSueldo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIngresarSueldo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 63);
            this.panel1.TabIndex = 0;
            // 
            // lblIngresarSueldo
            // 
            this.lblIngresarSueldo.AutoSize = true;
            this.lblIngresarSueldo.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarSueldo.Location = new System.Drawing.Point(47, 22);
            this.lblIngresarSueldo.Name = "lblIngresarSueldo";
            this.lblIngresarSueldo.Size = new System.Drawing.Size(190, 23);
            this.lblIngresarSueldo.TabIndex = 3;
            this.lblIngresarSueldo.Text = "Ingresar Sueldo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Lime;
            this.btnCerrar.Location = new System.Drawing.Point(494, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 52);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtIngresarSueldo
            // 
            this.txtIngresarSueldo.BackColor = System.Drawing.Color.Black;
            this.txtIngresarSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresarSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarSueldo.ForeColor = System.Drawing.Color.Lime;
            this.txtIngresarSueldo.Location = new System.Drawing.Point(47, 103);
            this.txtIngresarSueldo.Name = "txtIngresarSueldo";
            this.txtIngresarSueldo.Size = new System.Drawing.Size(319, 30);
            this.txtIngresarSueldo.TabIndex = 1;
            this.txtIngresarSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresarSueldo_KeyPress);
            // 
            // btnAgregarSueldo
            // 
            this.btnAgregarSueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSueldo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSueldo.ForeColor = System.Drawing.Color.Lime;
            this.btnAgregarSueldo.Location = new System.Drawing.Point(437, 96);
            this.btnAgregarSueldo.Name = "btnAgregarSueldo";
            this.btnAgregarSueldo.Size = new System.Drawing.Size(128, 45);
            this.btnAgregarSueldo.TabIndex = 4;
            this.btnAgregarSueldo.Text = "Agregar";
            this.btnAgregarSueldo.UseVisualStyleBackColor = true;
            this.btnAgregarSueldo.Click += new System.EventHandler(this.btnAgregarSueldo_Click);
            // 
            // FrmIngresarSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(602, 187);
            this.Controls.Add(this.btnAgregarSueldo);
            this.Controls.Add(this.txtIngresarSueldo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresarSueldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmIngresarSueldo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresarSueldo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtIngresarSueldo;
        private System.Windows.Forms.Button btnAgregarSueldo;
    }
}