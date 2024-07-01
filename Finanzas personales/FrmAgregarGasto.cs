using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas_personales
{
    public partial class FrmAgregarGasto : Form
    {
        public FrmAgregarGasto()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarGasto_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            Tipo_GastoNegocio tipo_GastoNegocio = new Tipo_GastoNegocio();
            cbxTipo.DataSource = tipo_GastoNegocio.ListarTipo_Gasto();
            cbxTipo.ValueMember = "id";
            cbxTipo.DisplayMember = "descripcion";
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            GastoNegocio gastoNegocio = new GastoNegocio();
            Gasto gasto = new Gasto();
            try
            {
                gasto.Descripcion= txtDescripcion.Text;
                gasto.Importe = decimal.Parse(txtImporte.Text); 
                gasto.Tipo_gasto = (Tipo_Gasto)cbxTipo.SelectedItem;
                gasto.Fecha = DateTime.Now.Day;
                gasto.Mes = DateTime.Now.ToString("MMMM").ToUpper();
                gastoNegocio.Agregar(gasto);
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();
        }

        private void lblAgregarTipo_Click(object sender, EventArgs e)
        {
            FrmAgregarTipo frmAgregarTipo = new FrmAgregarTipo();
            frmAgregarTipo.ShowDialog();
            Cargar();

        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite numeros del 0 al 9, un solo punto (.) y solo 4 digitos despues de la coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.Contains(',') || (sender as TextBox).Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if ((sender as TextBox).Text.Contains(','))
            {
                string[] parts = (sender as TextBox).Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
