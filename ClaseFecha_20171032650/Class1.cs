using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Clase_Fechas
{
    class JLFechas
    {
        //Se declaran las variables en esta parte de manera privada para evitar modificaciones desde el programa main
        private DateTime JLFecha1;
        private DateTime JLFecha2;


        //Se utiliza el metodo de sobrecarga para en el programa main ingresar los datos del cliente y poder enviarlo luego a imprimirlo 
        public JLFechas(DateTime JLPFecha1, DateTime JLPFecha2) //Método por sobrecarga donde se irán sobrecargando los datos de las fechas ingresadas
        {
            JLFecha1 = JLPFecha1;
            JLFecha2 = JLPFecha2;
        }


        //Impresión de las fechas´para mostrarlas en el programa main si son invocadas
        public void JLFechaCorta()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Fecha corta: " + JLFecha1.ToShortDateString());
        }

        public void JLFechaLarga()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Fecha larga: " + JLFecha1.ToLongDateString());
        }

        public void JLFechaNumeroDiaAño()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Dia del año: " + JLFecha1.DayOfYear);
        }
        public void JLFechaLargoSemana()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Dia de la semana: " + JLFecha1.DayOfWeek);
        }

        public void JLFechaLargoMes()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Mes: " + JLFecha1.ToString("MMMM"));
        }

        public void JLFechaComparar()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            JLFecha2 = Convert.ToDateTime(Console.ReadLine());

            if (JLFecha1 > JLFecha2)
            {
                Console.WriteLine("Fecha1: " + JLFecha1.ToString("dd-MMM-yyyy") + " es mayor que Fecha2: " + JLFecha2.ToString("dd-MMMM-yyyy"));
            }
            else
            {
                Console.WriteLine("Fecha2: " + JLFecha2.ToString("dd-MMM-yyyy") + " es mayor que Fecha1: " + JLFecha1.ToString("dd-MMMM-yyyy"));
            }
        }

        public void JLFechaAñadirQuitarDias()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Agregar 7 dias: " + JLFecha1.AddDays(7).ToString("dd-MMMM-yyyy"));
            Console.WriteLine("Restar 11 dias: " + JLFecha1.AddDays(-11).ToString("dd-MMMM-yyyy"));
        }

        public void JLFechaAñadirQuitarMeses()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Agregar 3 Meses: " + JLFecha1.AddMonths(3).ToString("dd-MMMM-yyyy"));
            Console.WriteLine("Restar 1 Mes: " + JLFecha1.AddMonths(-1).ToString("dd-MMMM-yyyy"));
        }

        public void JLFechaAñadirQuitarAños()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Agregar 38 Años: " + JLFecha1.AddYears(38).ToString("dd-MMMM-yyyy"));
            Console.WriteLine("Restar 4 Años: " + JLFecha1.AddYears(-4).ToString("dd-MMMM-yyyy"));
        }

        public void JLFechaTiempoLargo()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Mostrar formato hora largo (Tiempo Largo): " + JLFecha1.ToLongTimeString());
        }

        public void JLFechaDiaMes()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Mostrar Dia y Mes: " + JLFecha1.ToString("dd-MMMM"));
        }

        public void JLFechaMesAño()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Mostrar Mes y Año: " + JLFecha1.ToString("MMMM-yyyy"));
        }

        public void JLFechaPMAM()
        {
            JLFecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Hora del dia: " + JLFecha1.ToString("tt"));
        }
    }
}

