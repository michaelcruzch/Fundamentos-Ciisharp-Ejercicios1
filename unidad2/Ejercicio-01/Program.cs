using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

            int a, b, Resultado;
            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Resultado = a + b;

            Console.WriteLine("El resultado de la suma es: " + Resultado);



            
        }
    }
}
 