using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string patente;
        do
        {
            Console.WriteLine("Ingrese la patente del automóvil (o 'salir' para terminar):");
            patente = Console.ReadLine();

            if (patente.ToLower() != "salir")
            {
                if (EsPatenteValida(patente))
                {
                    Console.WriteLine("La patente es válida.");
                }
                else
                {
                    Console.WriteLine("La patente no es válida.");
                }
            }

        } while (patente.ToLower() != "salir"); // Continúa hasta que el usuario escriba "salir"
    }

    static bool EsPatenteValida(string patente)
    {
        if (string.IsNullOrWhiteSpace(patente))
            return false;

        string patron = @"^(?:[A-Z]{3}\d{3}|[A-Z]{2}\d{4})$";
        return Regex.IsMatch(patente.ToUpper(), patron);
    }
}
