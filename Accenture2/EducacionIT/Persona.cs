using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT
{
    public abstract class Persona //de esta clase no voy a crear instancia es abstracta
    {
        private int dni;
        private string apellido;
        private Pais pais;
        private List<Telefono> telefonos;
        public int Dni
        {
            get { return dni; }

            set { dni = value; }
        }

        public string Apellido  //para poner en Mayuscula es mas facil aca 
        {
            get { return apellido.ToUpper(); }

            set { apellido = value; }
        }

        public Pais Pais
        {
            get { return pais; }

            set { pais = value; }
        }

        //properties autoimplementadas
        public string Nombre { get; set; } //prop y doble tab despues se abre en caso de poner en Mayuscula

        //metodos
        /// <summary>
        /// Esto devuelve apellido, nombre y dni
        /// Autor : Accenture
        /// Fecha : 15/03/2021
        /// </summary>
        /// <returns></returns>

        public List<Telefono> Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }

        public virtual string TraerDatos()
        {
            // Buono, Antonella - DNI: 41079100 Nacio en Argentina
            string strDatos;
            strDatos = Apellido + "," + Nombre + " * DNI:" + Dni + " Nacio en " + Pais.Nombre;
            return strDatos;
        }


        public virtual string TraerDatos(string titulo)
        {
            //Srta Buono Antonella
            string strDatos;
            strDatos = titulo + " " + Apellido + "," + Nombre;
            return strDatos;
        }

    }
}
