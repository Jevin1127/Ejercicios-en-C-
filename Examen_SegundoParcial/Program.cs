using System;
using System.Collections.Generic;

namespace Examen_SegundoParcial
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variables Locales a utilizar 
            char JLSeguir = 'S';
            int JLEleccion = 0;
            int JLi = 0, JLNota1 = 0, JLNota2 = 0, JLNota3 = 0, JLEleccionFecha = 0, JLCantidadAños = 0;
            string JLFechaIngresada = "", JLPrincipal = "", JLTextoSustituto = "", JLSustituirPor = "";
            double JLPromedio = 0;
            DateTime JLFechaConvertida; 


            List<int> JLElecciondeOperacion = new List<int>();
            List<string> JLOpciones = new List<string>();

            JLOpciones.Add("1. Calcular el Promedio del Alumnos");
            JLOpciones.Add("2. Permitir añadir o restar años a una fecha ingresada y mostrar la nueva fecha");
            JLOpciones.Add("3. Sustituir texto de una cadena de texto");
            JLOpciones.Add("4. Calcular el Total para una factura");
            JLOpciones.Add("5. Retornar la fecha larga de una fecha ingresada");
            JLOpciones.Add("6. Convertir a Minusculas un texto");
            JLOpciones.Add("7. Comparar dos fechas e indicar al usuario cuál de las dos es menor, mayor o iguales");

            JLOperacionesVarias JLObjOperaciones = new JLOperacionesVarias();

            //Estructura de iteración para asiganar los valores como el nombre del alumno, cuenta y nota.
            while (JLSeguir.Equals('S') || JLSeguir.Equals('s'))
            {

                for (JLi = 0; JLi < JLOpciones.Count; JLi++)
                {
                    Console.WriteLine(JLOpciones[JLi]);
                }

                JLEleccion = int.Parse(Console.ReadLine());

                if (JLEleccion == 1)
                {
                    Console.WriteLine("Ingrese nota I Parcial: ");
                    JLNota1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese nota II Parcial: ");
                    JLNota2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese nota III Parcial: ");
                    JLNota3 = int.Parse(Console.ReadLine());   

                    Console.WriteLine("El promedio total del alumno es: " + JLObjOperaciones.JLCalculoIndiceAlumno(JLNota1, JLNota2, JLNota3));
                }
                else if (JLEleccion == 2)
                {

                    Console.WriteLine("Si desea agregar años Presione 1 ");
                    Console.WriteLine("Si desea quitar años Presione 2 ");
                    JLEleccionFecha = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la fecha en el siguiente formato 'dd/mm/yyyy'");
                    JLFechaIngresada = Console.ReadLine();
                    JLFechaConvertida = Convert.ToDateTime(JLFechaIngresada);

                    Console.WriteLine("Ingrese la cantidad de años que desea Agregar/Quitar: ");
                    JLCantidadAños = int.Parse(Console.ReadLine());

                    Console.WriteLine(" La nueva fecha es: " + JLObjOperaciones.JLFechaAñadirQuitarAños(JLFechaConvertida, JLEleccionFecha, JLCantidadAños));
                    
                }

                else if (JLEleccion == 3)
                {
                    Console.WriteLine("Ingrese el texto principal: ");
                    JLPrincipal = Console.ReadLine();
                    Console.WriteLine("Ingrese el texto a sustituir: ");
                    JLTextoSustituto = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo texto: ");
                    JLSustituirPor = Console.ReadLine();
                    Console.WriteLine("El nuevo texto es: " + JLObjOperaciones.JLReemplazar(JLPrincipal, JLTextoSustituto, JLSustituirPor));
                }

                else if (JLEleccion == 4)
                {
                    Console.WriteLine("El resultado es igual a: " + JLObjOperaciones.JLTotalFactura());

                }

                else if (JLEleccion == 5)
                {

                    Console.WriteLine("Ingrese la fecha en el siguiente formato 'dd/mm/yyyy'");
                    JLFechaIngresada = Console.ReadLine();
                    JLFechaConvertida = Convert.ToDateTime(JLFechaIngresada);

                    Console.WriteLine("La fecha larga es: " + JLObjOperaciones.JLFechaLarga(JLFechaConvertida));
                }

                else if (JLEleccion == 6)
                {
                    Console.WriteLine("Ingrese el texto: ");
                    JLPrincipal = Console.ReadLine();
                }
                else if (JLEleccion == 7)
                {


                }
                Console.WriteLine();
                Console.Write("¿Desea continuar el programa? S/N: ");
                JLSeguir = char.Parse(Console.ReadLine());
                Console.Clear();
            }


        }


    }
}

