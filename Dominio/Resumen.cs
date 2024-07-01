using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Resumen
    {
        public int Id { get; set; }
        public string Mes { get; set; }
        public decimal Total_gasto { get; set; }
        public decimal Sueldo { get; set; }
        public decimal Otros_ingresos { get; set; }
        public decimal Total { get; set; }

    }
}
