using EjerciciosExamen.Ejercicios;

namespace EjerciciosExamen.Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio1 ejercicio1 = new Ejercicio1();

            // ---------------------------------------------

            // Ejercicio2 ejercicio2 = new Ejercicio2();

            // ----------------------------------------------

            // Console.WriteLine("Ingrese el numero de tabla que desea ver:");
            // int.TryParse(Console.ReadLine(), out int tabla);

            // Console.WriteLine("Ingrese el limite de números a visualizar:");
            // int.TryParse(Console.ReadLine(), out int limite) ;

            // Ejercicio3 ejercicio3 = new Ejercicio3(tabla, limite);

            // --------------------------------------------------------------
            
            Ejercicio4 Producto1 = new Ejercicio4("Llave 10", 65, 40);
            Ejercicio4 Producto2 = new Ejercicio4("Alicate", 50, 35);

            Console.WriteLine(Producto1.ObtenerInfo());
            Console.WriteLine($"Valor del inventario : {Producto1.CalcularValorInventario(65, 40)}");

            Console.WriteLine(Producto1.ObtenerInfo());
            Console.WriteLine($"Valor del inventario : {Producto2.CalcularValorInventario(50, 35)}");

            Console.WriteLine("Después del descuento");
            Console.WriteLine();
           

        }
    }
}
