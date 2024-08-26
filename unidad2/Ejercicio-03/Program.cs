using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la 
            //velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que
            // demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            
            float Km, Velocidad, Resultado;

            Console.WriteLine("Ingrese la distancia existente entre las dos ciudades:");
            Km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad el vehiculo:");
            Velocidad = float.Parse(Console.ReadLine());

            Resultado = (1 * Km) / 100;

            Console.WriteLine("El tiempo aproximado que que demanda el viaje es: " + Resultado + " Horas");
        }
    }
}
