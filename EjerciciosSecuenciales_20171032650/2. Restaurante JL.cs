using System;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración inicialización de Variables y Constantes 

            int JLCantidadHamburguesas = 0, JLCantidadBebidas = 0, JLCantidadPostres = 0, JLISVH = 0, JLISVB = 0;
            const double JLPrecioHamburguesas = 140;
            const double JLPrecioBebidas = 35;
            const double JLPrecioPostres = 50;
            const double JLISV = 0.016;
            double JLSubPago = 0;
            double JLPago = 0;
            double JLISVT = 0;
            string Linea = "";


            //Lectura de Datos 
            Console.Write("Hamburguesas El Pumita");
            Console.WriteLine();
            Console.Write("           Menú ");
            Console.WriteLine();
            Console.Write(" Hamburguesas__________140 lps ");
            Console.WriteLine();
            Console.Write(" Bebidas________________35 lps ");
            Console.WriteLine();
            Console.Write(" Postres________________50 lps ");
            Console.WriteLine();
            Console.Write("Ingrese la cantidad de Hamburguesas que va ordenar: ");
            Linea = Console.ReadLine();
            JLCantidadHamburguesas = int.Parse(Linea);
            Console.WriteLine("Ingrese la cantidad de Bebidas que va ordenar: ");
            Linea = Console.ReadLine();
            JLCantidadBebidas = int.Parse(Linea);
            Console.WriteLine("Ingrese la cantidad de Postres que va ordenar: ");
            Linea = Console.ReadLine();
            JLCantidadPostres = int.Parse(Linea);
            Console.WriteLine();

            //Calculo 
            JLSubPago = (JLCantidadHamburguesas * JLPrecioHamburguesas) + (JLCantidadBebidas * JLPrecioBebidas) + (JLCantidadPostres * JLPrecioPostres);
            JLISVH = (int)(JLCantidadHamburguesas * JLPrecioHamburguesas * JLISV);
            JLISVB = (int)(JLCantidadBebidas * JLPrecioBebidas * JLISV);
            JLISVT = (JLISVH + JLISVB);
            JLPago = (JLCantidadHamburguesas * JLPrecioHamburguesas + JLISVH) + (JLCantidadBebidas * JLPrecioBebidas + JLISVB) + (JLCantidadPostres * JLPrecioPostres);

            //Salida con el pago total

            Console.WriteLine("Su Sub Total a pagar es: " + JLSubPago, "LPS");
            Console.Write("Se le cobrará un ISV del 16% por 2 productos comprados");
            Console.WriteLine("");
            Console.Write("Su Total a pagar de ISV del 16% es: " + JLISVT, "LPS");
            Console.WriteLine("");
            Console.Write("Su Total a pagar es: " + JLPago, "LPS");
            Console.WriteLine("");
            Console.Write("Pulse Cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
