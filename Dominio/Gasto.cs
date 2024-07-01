using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Tipo_Gasto Tipo_gasto { get; set; }
        public decimal Importe { get; set; }
        public string Mes { get; set; }
        public int Fecha { get; set; }

    }
}
