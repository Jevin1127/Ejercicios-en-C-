using System;

namespace Operaciones_Matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables y constantes

            int JLPrimerNumero = 0, JLSegundoNumero = 0;
            string Linea = "";
            int JLSuma = 0;
            int JLResta = 0;
            int JLMultiplicacion = 0;
            int JLDivision = 0;
            int JLResiduo = 0;

            //Lectura de Datos
            Console.Write("Calculadora Operacional");
            Console.WriteLine();
            Console.Write("Ingrese el primer numero ");
            Linea = Console.ReadLine();
            JLPrimerNumero = int.Parse(Linea);
            Console.Write("Ingrese el segundo numero ");
            Linea = Console.ReadLine();
            JLSegundoNumero = int.Parse(Linea);
            Console.WriteLine();

            //Calculo
            JLSuma = (JLPrimerNumero + JLSegundoNumero);
            JLResta = (JLPrimerNumero - JLSegundoNumero);
            JLMultiplicacion = (JLPrimerNumero * JLSegundoNumero);
            JLDivision = (JLPrimerNumero / JLSegundoNumero);
            JLResiduo = (JLPrimerNumero % JLSegundoNumero);

            //Salida con los resultados Finales
            Console.WriteLine("La Suma de los dos digitos es: " + JLSuma);
            Console.WriteLine("La Resta de los dos digitos es: " + JLResta);
            Console.WriteLine("La Multiplicacion de los dos digitos es: " + JLMultiplicacion);
            Console.WriteLine("La Division de los dos digitos es: " + JLDivision);
            Console.WriteLine("El residuo de los dos digitos es: " + JLResiduo);
            Console.Write("Pulse Cualquier tecla para salir");
            Console.ReadLine();

        }
    }
}
