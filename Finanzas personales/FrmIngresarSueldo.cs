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
    public partial class FrmIngresarSueldo : Form
    {
        public FrmIngresarSueldo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarSueldo_Click(object sender, EventArgs e)
        {
            ResumenNegocio resumenNegocio = new ResumenNegocio();
            decimal sueldo;
            string mes;
            try
            {
                sueldo = decimal.Parse(txtIngresarSueldo.Text);
                mes = DateTime.Now.ToString("MMMM").ToUpper();
                if (resumenNegocio.GetSueldo(mes) != 0)
                {
                    resumenNegocio.UpdateSueldo(sueldo, mes);
                }
                else
                {
                    resumenNegocio.AgregarSueldo(sueldo, mes);
                }                    
            }
            catch (Exception)
            {
                throw;
            }
            this.Close();
        }

        private void txtIngresarSueldo_KeyPress(object sender, KeyPressEventArgs e)
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
