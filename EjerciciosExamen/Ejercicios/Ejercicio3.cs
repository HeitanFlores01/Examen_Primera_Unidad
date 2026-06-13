namespace EjerciciosExamen.Ejercicios
{
    public class Ejercicio3
    {
        public Ejercicio3(int tabla, int limite)
        {
            Console.WriteLine($"TABLA DE MULTIPLICAR DEL {tabla} ");
            Console.WriteLine("==================================");

            if(tabla > 0)
            {
                for (int i = 1; i <= limite; i++)
                {
                  Console.WriteLine($"{tabla} x {i} = {tabla * i}");
                }
            }
            else
            {
                Console.WriteLine("El número de tabla debe ser mayor a cero.");
            }
        }
    }
}