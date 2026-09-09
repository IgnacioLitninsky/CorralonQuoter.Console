using System;
using System.Collections.Generic;
using System.Text;

namespace CorralonQuoter
{
    internal class ItemPresupuesto
    {
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }

        public decimal Subtotal => Producto.Precio * Cantidad;
    }
}
