using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego 
            //calcule y emita por pantalla el promedio final.

            float Nota1, Nota2, Nota3, PromedioFinal;

            Console.WriteLine("Ingrese nota 1: ");
            Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2: ");
            Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3: ");
            Nota3 = float.Parse(Console.ReadLine());

            PromedioFinal = (Nota1 + Nota2 + Nota3) / 3;

            Console.WriteLine("El promedio final del alumno es: " + PromedioFinal);
        }
    }
}
