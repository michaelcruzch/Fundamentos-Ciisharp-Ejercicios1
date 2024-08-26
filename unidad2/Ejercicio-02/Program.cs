using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            int a, Resultado;
            
            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());

            Resultado = a * a * a;

            Console.WriteLine("El resultado es:" + Resultado);



        }
    }
}
