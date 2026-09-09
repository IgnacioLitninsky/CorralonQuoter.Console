using System;
using System.Collections.Generic;
using System.Text;

namespace CorralonQuoter
{
    internal class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Rubro { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
    }
}
