using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas_personales
{
    public partial class FrmAgregarOtrosIngresos : Form
    {
        public FrmAgregarOtrosIngresos()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            OtroIngresoNegocio otroIngresoNegocio = new OtroIngresoNegocio();
            List<OtroIngreso> otroIngresos;
            try
            {
                otroIngresos = otroIngresoNegocio.listar();
                dgvOtrosIngresos.DataSource = otroIngresos;
            }
            catch (Exception)
            {
                throw;
            }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarOtrosIngresos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregarOtrosIngresos_Click(object sender, EventArgs e)
        {
            OtroIngresoNegocio otroIngresoNegocio = new OtroIngresoNegocio();
            OtroIngreso otroIngreso = new OtroIngreso();
            try
            {
                otroIngreso.Descripcion = txtDescripcion.Text;
                otroIngreso.Importe = decimal.Parse(txtImporte.Text);
                otroIngreso.Fecha = DateTime.Now.ToString("d").ToUpper();
                otroIngreso.Mes = DateTime.Now.ToString("MMMM").ToUpper();
                otroIngresoNegocio.Agregar(otroIngreso);
            }
            catch (Exception)
            {

                throw;
            }
            Cargar();
            txtDescripcion.Clear();
            txtImporte.Clear();
        }
        private void GuardarResumen()
        {
            // Obtener la ruta de la carpeta donde se guardará el archivo
            string rutaCarpeta = @"C:\Users\anton\OneDrive\Escritorio\ResumenGastos"; // Ruta de la carpeta deseada
            string nombreArchivo = DateTime.Now.ToString("MMMM").ToUpper() + "-RESUMEN-EXTRAS.txt"; // Nombre del archivo
            // Comprobar si la carpeta existe, si no, crearla
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            // Combinar la ruta de la carpeta con el nombre del archivo
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

            // Obtener los datos del formulario
            string datosAGuardar = ObtenerDatosParaGuardar();

            // Escribir los datos en el archivo de texto
            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                sw.WriteLine(datosAGuardar);
            }

            MessageBox.Show("Datos guardados correctamente en: " + rutaCompleta);
        }

        // Método para obtener los datos del formulario y formatearlos para guardar
        private string ObtenerDatosParaGuardar()
        {
            // Aquí debes incluir la lógica para obtener los datos del formulario
            // y formatearlos como desees para guardar en el archivo de texto
            // Por ejemplo:
            string fila = null;
            string filas = null;
            int cont = 1;
            string datosFormateados = "DETALLE OTROS INGRESOS" + Environment.NewLine;

            foreach (DataGridViewRow row in dgvOtrosIngresos.Rows)
            {
                // Iterar a través de las celdas de cada fila

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Agregar el valor de la celda seguido de una coma (o el separador que desees)


                    if (cell.Value.GetType() == typeof(decimal))
                    {
                        fila += "$" + cell.Value.ToString() + " ";
                    }
                    else
                    {
                        fila += cell.Value.ToString().ToUpper() + " ";
                    }

                }
                // Agregar una nueva línea al final de cada fila
                filas += cont + " .- " + fila + Environment.NewLine;
                cont++;
                fila = "";
            }
            datosFormateados += filas + Environment.NewLine;
            return datosFormateados;

        }

        private void lblGenerarResumenIngresosExtras_Click(object sender, EventArgs e)
        {
            GuardarResumen();
        }

        private void llblEliminarOtrosIngresos_Click(object sender, EventArgs e)
        {
            OtroIngresoNegocio otroIngresoNegocio = new OtroIngresoNegocio();
            OtroIngreso otroIngreso = new OtroIngreso();
            try
            {
                if (dgvOtrosIngresos.CurrentRow != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        otroIngreso = (OtroIngreso)dgvOtrosIngresos.CurrentRow.DataBoundItem;
                        otroIngresoNegocio.Eliminar(otroIngreso.Id);
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
