namespace CorralonQuoter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var p = new Producto();
            p.Precio = 9850.50m;
            p.Descripcion = "Cemento Portland x 50kg";
            Console.WriteLine(p.Descripcion + " - $" + p.Precio);
        }
    }
}
