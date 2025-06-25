using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tarea_3_JuepoJPS
{
    public class TP3Context : DbContext
    {
        public TP3Context() : base("name=TP3Connection") { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Numero> Numeros { get; set; }
    }
}