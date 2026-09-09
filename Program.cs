namespace CorralonQuoter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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

            foreach (var p in catalogo)
            {
                Console.WriteLine(p.Descripcion + " - $" + p.Precio);
            }
        }
    }
}
