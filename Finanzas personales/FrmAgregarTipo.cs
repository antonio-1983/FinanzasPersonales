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
    public partial class FrmAgregarTipo : Form
    {
        public FrmAgregarTipo()
        {
            InitializeComponent();
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            Tipo_GastoNegocio tipo_GastoNegocio = new Tipo_GastoNegocio();
            Tipo_Gasto tipo_Gasto = new Tipo_Gasto();
            try
            {
                tipo_Gasto.Descripcion = txtIngresarTipo.Text;
                tipo_GastoNegocio.Agregar(tipo_Gasto);
            }
            catch (Exception)
            {

                throw;
            }
            Cargar();
            txtIngresarTipo.Clear();
        }

        private void Cargar()
        {
            Tipo_GastoNegocio tipo_GastoNegocio = new Tipo_GastoNegocio();
            List<Tipo_Gasto> tipo_Gastos;
            try
            {
                tipo_Gastos = tipo_GastoNegocio.ListarTipo_Gasto();
                dgvTipo.DataSource = tipo_Gastos;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void FrmAgregarTipo_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblEliminarTipo_Click(object sender, EventArgs e)
        {
            Tipo_GastoNegocio tipo_GastoNegocio = new Tipo_GastoNegocio();
            Tipo_Gasto tipo_Gasto;
            try
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    tipo_Gasto = (Tipo_Gasto)dgvTipo.CurrentRow.DataBoundItem;
                    if (tipo_GastoNegocio.GetTipo_gasto(tipo_Gasto.Id))
                    {
                        MessageBox.Show("no se puede eliminar porque se esta usando la Actividad en una tarea");
                    }
                    else
                    {
                        tipo_GastoNegocio.Eliminar(tipo_Gasto.Id);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Cargar();

        }
    }
}
