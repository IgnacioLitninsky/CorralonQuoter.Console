using System.Linq;

namespace CorralonQuoter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> catalogo = new List<Producto>();

            catalogo.Add(new Producto
            {
                Codigo = "CEM-050",
                Descripcion = "Cemento Portland x 50kg",
                Proveedor = "J.F.A",
                Marca = "JFA",
                Rubro = "Ferreteria",
                Precio = 9850m,
                Stock = 30m
            });

            catalogo.Add(new Producto
            {
                Codigo = "193473",
                Descripcion = "PILA ENERGIZER AA",
                Proveedor = "PILAS",
                Marca = "PILAS",
                Rubro = "Ferreteria",
                Precio = 1250m,
                Stock = 59m
            });

            catalogo.Add(new Producto
            {
                Codigo = "254763",
                Descripcion = "CAÑO PILAR 1 1/2 X 3 MTS",
                Proveedor = "J.F.A",
                Marca = "JFA",
                Rubro = "Electricidad",
                Precio = 4200m,
                Stock = 15m
            });

            catalogo.Add(new Producto
            {
                Codigo = "GRIF-001",
                Descripcion = "GRIFERIA PEIRANO JUEGO X 3",
                Proveedor = "MULTI MARCA",
                Marca = "PEIRANO",
                Rubro = "Sanitarios",
                Precio = 231599.44m,
                Stock = 8m
            });

            catalogo.Add(new Producto
            {
                Codigo = "112322",
                Descripcion = "SOPORTE TIPO FERRUM ADRIATICO Y PILAR",
                Proveedor = "70/30",
                Marca = "70/30",
                Rubro = "Ferreteria",
                Precio = 3100m,
                Stock = 10m
            });

            string busqueda = "pila";

            var resultados = catalogo
                .Where(p => p.Descripcion.ToLower()
                    .Split(' ')
                    .Contains(busqueda.ToLower()))
                .ToList();

            List<ItemPresupuesto> presupuesto = new List<ItemPresupuesto>();

            var pila = catalogo.First(p => p.Codigo == "193473");
            presupuesto.Add(new ItemPresupuesto { Producto = pila, Cantidad = 3m });

            var cano = catalogo.First(p => p.Codigo == "254763");
            presupuesto.Add(new ItemPresupuesto { Producto = cano, Cantidad = 2m });

            decimal total = presupuesto.Sum(item => item.Subtotal);

            string textoWhatsApp = GenerarTextoPresupuesto(presupuesto, total);
            Console.WriteLine(textoWhatsApp);
        }

        static string GenerarTextoPresupuesto(List<ItemPresupuesto> presupuesto, decimal total)
        {
            string texto = "*PRESUPUESTO*\n";
            texto += "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n\n";

            foreach (var item in presupuesto)
            {
                texto += "• " + item.Producto.Descripcion + " — " + item.Cantidad + " x $" + item.Producto.Precio + " = $" + item.Subtotal + "\n";
            }

            texto += "\n*TOTAL: $" + total + "*";

            return texto;
        }
    }
}
