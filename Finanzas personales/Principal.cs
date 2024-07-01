using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Finanzas_personales
{
    
    public partial class FrmFinanzasPersonales : Form
    {
        private List<Gasto> listGasto;
        private FrmIngresarSueldo frmIngresarSueldo;
        public FrmFinanzasPersonales()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFinanzasPersonales_Load(object sender, EventArgs e)
        {
            lblMes.Text = DateTime.Now.ToString("MMMM").ToUpper();
            Cargar();
        }
        private void Cargar()
        {
            GastoNegocio negocio = new GastoNegocio();
            ResumenNegocio resumenNegocio = new ResumenNegocio();
            OtroIngresoNegocio otroIngresoNegocio = new OtroIngresoNegocio();
            decimal importeSaldo;
            decimal sueldo;
            decimal totalIngresos;
            string mes;
            try
            {
                listGasto = negocio.listar();
                dgvDetalle.DataSource = listGasto;
                lblImporteGastos.Text = negocio.TotalGasto().ToString("0.##");
                mes = DateTime.Now.ToString("MMMM").ToUpper();
                sueldo = resumenNegocio.GetSueldo(mes);
                lblImporteSueldo.Text = sueldo.ToString("0.##");
                lblImporteOtrosIngresos.Text = otroIngresoNegocio.TotalOtrosIngresos().ToString("0.##");
                totalIngresos = (decimal.Parse(lblImporteSueldo.Text) + decimal.Parse(lblImporteOtrosIngresos.Text));
                lblImporteTotalIngresos.Text = totalIngresos.ToString("0.##");
                importeSaldo = totalIngresos-decimal.Parse(lblImporteGastos.Text);
                lblImporteSaldo.Text = importeSaldo.ToString("0.##");
                
                OcultarColumnas();

            }
            catch (Exception )
            {
                throw;
            }
        }
        private void OcultarColumnas()
        {
            dgvDetalle.Columns["Id"].Visible = false;
        }

        private void lblIngresarSueldo_Click(object sender, EventArgs e)
        {
            frmIngresarSueldo = new FrmIngresarSueldo();
            frmIngresarSueldo.ShowDialog();
            Cargar();
        }

        private void lblIngresarGasto_Click(object sender, EventArgs e)
        {
            FrmAgregarGasto frmAgregarGasto = new FrmAgregarGasto();
            frmAgregarGasto.ShowDialog();
            Cargar();
        }

        private void llblEliminarGasto_Click(object sender, EventArgs e)
        {
            GastoNegocio gastoNegocio = new GastoNegocio();
            Gasto gasto = new Gasto();
            try
            {
                if (dgvDetalle.CurrentRow != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        gasto = (Gasto)dgvDetalle.CurrentRow.DataBoundItem;
                        gastoNegocio.Eliminar(gasto.Id);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Cargar();
        }

        private void lblGenerarResumen_Click(object sender, EventArgs e)
        {
            ResumenNegocio resumenNegocio = new ResumenNegocio();
            Resumen resumen = new Resumen();
            try
            {
                resumen.Total_gasto = decimal.Parse(lblImporteGastos.Text);
                resumen.Total = decimal.Parse(lblImporteSaldo.Text);
                resumen.Mes = DateTime.Now.ToString("MMMM").ToUpper();
                resumen.Sueldo = decimal.Parse(lblImporteSueldo.Text);
                resumen.Otros_ingresos = decimal.Parse(lblImporteOtrosIngresos.Text);
                if(resumenNegocio.GetSueldo(resumen.Mes)!=0)
                {
                    resumenNegocio.UpdateResumen(resumen);
                }
                else
                {
                    resumenNegocio.Agregar(resumen);
                }
            }
            catch (Exception)
            {

                throw;
            }
            GuardarResumen();
        }
        /***************************************************************************/
         private void GuardarResumen()
        {
            // Obtener la ruta de la carpeta donde se guardará el archivo
            string rutaCarpeta = @"C:\Users\anton\OneDrive\Escritorio\ResumenGastos"; // Ruta de la carpeta deseada
            string nombreArchivo = DateTime.Now.ToString("MMMM").ToUpper() + ".txt"; // Nombre del archivo
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
            string datosFormateados = "MES: " + lblMes.Text + Environment.NewLine;
            datosFormateados += "SUELDO: $" + lblImporteSueldo.Text + Environment.NewLine;
            datosFormateados += "OTROS INGRESOS $" + lblImporteOtrosIngresos.Text + Environment.NewLine;
            datosFormateados += "TOTAL INGRESOS MENSUALES: $" + lblImporteTotalIngresos.Text + Environment.NewLine;
            datosFormateados += "GASTOS MENSUALES: $" + lblImporteGastos.Text + Environment.NewLine;
            datosFormateados += "SALDO: $" + lblImporteSaldo.Text + Environment.NewLine;
            datosFormateados += Environment.NewLine;
            datosFormateados += "DETALLE GASTOS" + Environment.NewLine;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                // Iterar a través de las celdas de cada fila
                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Agregar el valor de la celda seguido de una coma (o el separador que desees)
                    
                    
                    if(cell.Value.GetType() == typeof(decimal))
                    {
                        fila += "$" + cell.Value.ToString() + " ";
                    }
                    else
                    {
                        fila += cell.Value.ToString().ToUpper() + " ";
                    }    
                    
                }
                // Agregar una nueva línea al final de cada fila
                filas +=cont + " .- " + fila + Environment.NewLine;
                cont++;
                fila = "";
            }
            datosFormateados += filas + Environment.NewLine;
            return datosFormateados;
            
        }

        private void lblIngresarOtrosIngresos_Click(object sender, EventArgs e)
        {
            FrmAgregarOtrosIngresos frmAgregarOtrosIngresos = new FrmAgregarOtrosIngresos();
            frmAgregarOtrosIngresos.ShowDialog();
            Cargar();
        }
    }
}
