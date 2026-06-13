namespace EjerciciosExamen.Ejercicios
{
    public class Ejercicio2
    {
        public Ejercicio2()
        {
            double Saldo = 35000.00;
            String Categoria;

            if(Saldo < 1000)
            {
                Categoria = "Basico";
                Console.WriteLine($"Categoría asignada : {Categoria}");
                Console.WriteLine("Abra un CDT para mejorar su categoría");
            }
            else if(Saldo >= 1000 && Saldo <= 4999)
            {
                Categoria = "Plata";
                Console.WriteLine($"Categoría asignada : {Categoria}");
                Console.WriteLine("Tiene acceso a tarjeta de débito sin comisión.");
            }
             else if(Saldo >= 5000 && Saldo <= 19999)
            {
                Categoria = "Oro";
                Console.WriteLine($"Categoría asignada : {Categoria}");
                Console.WriteLine("¡Felicidades! Accede a tasas preferenciales.");
            }
             else if(Saldo > 20000)
            {
                Categoria = "Platino";
                Console.WriteLine($"Categoría asignada : {Categoria}");
                Console.WriteLine("¡Cliente VIP! Accede a todos los beneficios del banco.");
            }
        }
    }
}