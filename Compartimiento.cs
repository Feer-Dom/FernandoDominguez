using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Dominguez
{
    class Compartimiento
    {
        public int NumeroDeCompartimiento { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public Cliente Cliente { get; set; }

    }
}
