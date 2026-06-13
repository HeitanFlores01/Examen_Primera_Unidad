namespace EjerciciosExamen.Ejercicios
{
    public class Ejercicio4
    {
       public string Nombre {get; set;}
       public double Precio {get; set;}
       public int Stock {get; set;}

       public Ejercicio4(String nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public string ObtenerInfo()
        {
            return $"{Nombre} -- Precio: L. {Precio} -- Stock : {Stock}";
        }

        public double CalcularValorInventario(double precio, int stock, double inventario)
        {
            return inventario = precio * stock;
        }

        // public decimal AplicarDescuento (decimal porcentaje)
        // {
        //     porcentaje = inventario * 0.15m;
        // }


    }
}