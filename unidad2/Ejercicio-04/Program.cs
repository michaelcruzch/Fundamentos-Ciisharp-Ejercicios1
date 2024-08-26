using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% 
            //sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por
            // un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            int SueldoFijo = 15000;
            float TotalFacturado, SueldoTotalPagar, Comision = 0.05F;

            Console.WriteLine("Ingrese en total factura de este mes: ");
            TotalFacturado = float.Parse(Console.ReadLine());

            SueldoTotalPagar = (TotalFacturado * Comision ) + SueldoFijo;

            Console.WriteLine("El sueldo total a pagar es: " + SueldoTotalPagar);

        }
    }
}
