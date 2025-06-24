using System;

namespace Salario_Vendedores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables y constantes
            string JLNombre = "", JLHoras;
            int JLBruto = 0;
            double JLDIhss = 0;
            double JLBono = 0;
            int JLTotal = 0;
            int JLSubT = 0;

            //Lectura de Datos
            Console.Write(" Salario Total de Vendedores ");
            Console.WriteLine();
            Console.Write(" Ingrese su nombre:  ");
            JLNombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la cantidad de horas trabajadas:  ");
            JLHoras = Console.ReadLine();
            Console.WriteLine();

            //Calculos 
            JLBruto = int.Parse(JLHoras) * 125;
            JLDIhss = JLBruto * 0.045;
            JLSubT = (int)(JLBruto - JLDIhss);
            JLBono = JLSubT * 0.08;
            JLTotal = (int)(JLSubT + JLBono);


            //Salida con los resultados Finales
            Console.Write("El vendedor: " + JLNombre);
            Console.WriteLine();
            Console.Write("Gana un monto bruto de: " + JLBruto);
            Console.WriteLine();
            Console.Write("Con una deducción del IHSS del 4.5% de: " + JLDIhss);
            Console.WriteLine();
            Console.Write("Con un bono del 8% al monto neto de: " + JLBono);
            Console.WriteLine();
            Console.Write("Con un total de: " + JLTotal);
            Console.WriteLine();
            Console.Write("Presione enter para continuar");
            Console.ReadLine();
        }
    }
}
