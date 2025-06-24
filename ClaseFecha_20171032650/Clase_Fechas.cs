using System;

namespace Clase_Fechas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asignacion y Lectura
            DateTime JLFecha1 = new DateTime();
            DateTime JLFecha2 = new DateTime();
            char Seguir = 'S';
            int JLEleccionFecha;

            while (Seguir.Equals('S') || Seguir.Equals('s'))
            {
                Console.WriteLine("Bienvenido al Selector de Fechas");
                Console.WriteLine("Seleccione la opcion de fechas que desea usar: ");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1. Retornar la fecha corta de una fecha ingresada");
                Console.WriteLine("2. Retornar la fecha larga de una fecha ingresada");
                Console.WriteLine("3. Retornar el número de día del año de una fecha ingresada");
                Console.WriteLine("4. Retornar el nombre largo de día de la semana de una fecha ingresada");
                Console.WriteLine("5. Retornar el nombre largo del mes de una fecha ingresada");
                Console.WriteLine("6. Comprar dos fechas e indicar al usuario cuál de las dos es menor, mayor o iguales");
                Console.WriteLine("7. Permitir añadir o restar días a una fecha ingresada y mostrar la nueva fecha");
                Console.WriteLine("8. Permitir añadir o restar meses a una fecha ingresada y mostrar la nueva fecha");
                Console.WriteLine("9. Permitir añadir o restar años a una fecha ingresada y mostrar la nueva fecha");
                Console.WriteLine("10. Retornar solo el tiempo largo de una fecha y tiempo ingresada");
                Console.WriteLine("11. Retornar día y mes de una fecha ingresada");
                Console.WriteLine("12. Retornar mes y año de una fecha ingresada");
                Console.WriteLine("13. Retornar AM o PM de una fecha según la hora ingresada en formato 24H");
                JLEleccionFecha = int.Parse(Console.ReadLine());

                JLFechas ObjJLFechas = new JLFechas(JLFecha1, JLFecha2);

                //Se hace un switch case para elegir entre la opciones y hacerf cosas diferentes referente a lo que usuario pidió
                switch (JLEleccionFecha)
                {
                    case 1:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaCorta();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaLarga();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaNumeroDiaAño();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaLargoSemana();
                        break;
                    case 5:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaLargoMes();
                        break;
                    case 6:
                        Console.WriteLine("Ingrese la fecha 1: ");
                        Console.WriteLine("Ingrese la fecha 2: ");
                        ObjJLFechas.JLFechaComparar();
                        break;
                    case 7:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaAñadirQuitarDias();
                        break;
                    case 8:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaAñadirQuitarMeses();
                        break;
                    case 9:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaAñadirQuitarAños();
                        break;
                    case 10:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaTiempoLargo();
                        break;
                    case 11:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaDiaMes();
                        break;
                    case 12:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaMesAño();
                        break;
                    case 13:
                        Console.WriteLine("Ingrese la fecha: ");
                        ObjJLFechas.JLFechaPMAM();
                        break;
                    default:
                        Console.WriteLine("El Número Ingresado no esta entre las opciones mostradas");
                        break;
                }
                Console.WriteLine();
                Console.Write("Desea Continuar con otra Opción (S/N): ");
                Seguir = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}

