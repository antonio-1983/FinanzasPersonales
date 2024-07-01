using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class OtroIngreso

    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public decimal Importe { get; set; }
        public string Fecha { get; set; }
        public string Mes { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
