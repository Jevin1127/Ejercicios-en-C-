using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_SegundoParcial
{
    class JLOperacionesVarias
    {

        public double JLCalculoIndiceAlumno(int JLNota1, int JLNota2, int JLNota3)
        {
            return (JLNota1 + JLNota2 + JLNota3) / 3;
        }

        public DateTime JLFechaAñadirQuitarAños(DateTime JLFecha, int JLOpcion, int JLAnos)
        {
            DateTime JLResultado = DateTime.Now;

            if (JLOpcion == 1) {
                JLResultado = JLFecha.AddYears(JLAnos);
            } else if (JLOpcion == 2) {
                JLResultado = JLFecha.AddYears(-JLAnos);
            }

            return JLResultado;
        }

        public String JLReemplazar(String JLTextoPrincipal, String JLTextoSutituto, String JLTextoNuevo)
        {
            return JLTextoPrincipal.Replace(JLTextoSutituto, JLTextoNuevo);
        }


        public double JLTotalFactura()
        {
            double JLSubTotal, JLISV;

            Console.WriteLine("Ingrese el subtotal de factura");
            JLSubTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el subtotal el % de ISV");
            JLISV = double.Parse(Console.ReadLine());

            return (JLSubTotal * JLISV / 100) + JLSubTotal;
        }

        public string JLFechaLarga(DateTime JLFecha) {

            return JLFecha.ToLongDateString();
        }

        public string JLConvertirMinuscula(string JLTexto) {
            return JLTexto.ToLower();
        }
    }
}
