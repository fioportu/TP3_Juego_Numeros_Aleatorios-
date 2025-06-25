using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_JuepoJPS
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaHora { get; set; }

        public virtual ICollection<Numero> Numeros { get; set; }
    }
}
