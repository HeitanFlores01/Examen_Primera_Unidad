namespace EjerciciosExamen.Ejercicios
{
    public class Ejercicio1
    {
        public Ejercicio1()
        {
            String NombreProducto = "Fertilizante NPK";
            double PrecioPorKg = 35.75;
            int CantidadKg  = 12;
            double descuentoPorcentaje = 10;

            double subtotal = PrecioPorKg * CantidadKg;

            double descuento = subtotal * descuentoPorcentaje / 100;

            double totalFinal = subtotal - descuento;

            Console.WriteLine("=== FACTURA AGROCOPÁN ===");
            Console.WriteLine($"Producto  : {NombreProducto}");
            Console.WriteLine($"Cantidad  : {CantidadKg} kg");
            Console.WriteLine($"Precio/kg : L. {PrecioPorKg}");
            Console.WriteLine($"Subtotal  : L. {subtotal}");
            Console.WriteLine($"Descuento : L. {descuento}");
            Console.WriteLine($"Total     : L. {totalFinal}");
        }
    }
}