using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT
{
    public class Alumno : Persona
    {
        private int nota;

        //atributo estatico
        private static int notaTP;

        public int Nota { get; set; }

        public static int NotaTP {

            get { return notaTP; }
            set { notaTP = value; }
        }

        //metodos
        public override string TraerDatos() //es una sobrescritura
        {
            // Buono, Antonella - DNI: 41079100 Nacio en Argentina
            string strDatos;
            double notaPromedio = (Nota + NotaTP) / 2;
            strDatos = base.TraerDatos() + " Nota: " + Nota + " Nota Promedio: "+ notaPromedio;
            return strDatos;
        }


    }
}
