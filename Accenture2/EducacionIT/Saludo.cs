using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT
{
    public static class Saludo //sus metodos van a ser estaticos
    {
        public static string Saludar(string mensaje, string nombre)
        {
            string strSaludo = mensaje + " " + nombre;
            return strSaludo; 
        }
    }
}
