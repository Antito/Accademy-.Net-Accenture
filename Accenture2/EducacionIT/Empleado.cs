using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT
{
    public class Empleado : Persona
    {
        public Empleado ()
        {
            Sueldo = 45000;
            fechaIngreso = DateTime.Today;
        }

        public Empleado(double psueldo, DateTime pfecha) //constructor sobrecargado
        {
            Sueldo = psueldo;
            FechaIngreso = pfecha;
        }

        private double sueldo;
        private DateTime fechaIngreso;
        private static double aumento;

        public double Sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public static double Aumento { get; set; }

        //metodo
        public int TraerAntiguedad ()
        {
            int intAños;
            intAños = DateTime.Today.Year - FechaIngreso.Year;

            return intAños;
        }

        public double TraerSueldoFinal()
        {
            double sueldofinal = Sueldo + Aumento;
            return sueldofinal;
        }
    }
}
