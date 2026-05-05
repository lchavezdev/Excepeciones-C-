using System;

class Program
{
    static void Main()
    {
        int notas = 6;
        double suma = 0;

        Console.WriteLine("******BIENVENIDO A LA CALCULADORA DE PROMEDIOS******");
        for (int i = 1; i < notas; i++)
        {
            Console.Write($"Ingrese el valor de la nota {i}: ");
            string? entrada = Console.ReadLine();
            try
            {
                double nota = double.Parse(entrada);
                if (nota <= 0)
                {
                    throw new Exception("debe ser mayor que 0");
                }

                if (nota > 100)
                {
                    throw new Exception("debe estar entre 0 y 100");
                }
                suma += nota;
            }
            catch (FormatException)
            {
                Console.WriteLine("solo se aceptan números");
                i--;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                i--;
            }

        }
        Console.WriteLine("******CALCULO******");
        Console.WriteLine($"El promedio es: {suma / 5}");
    }
}