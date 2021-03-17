using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionIT
{
    public class Pais
    {
        //constructor
        public Pais()
        {
            //codigo a ejecutarse por cada instancia de clase
            Codigo = 54;
            Nombre = "Argentina";
            Region = "LATAM";
        }

        public Pais(int cod, string nombre, string reg)
        {
            Codigo = cod;
            Nombre = nombre;
            Region = reg;
        }


        //atributos
        private int codigo;
        private string nombre;
        private string region;

        //properties
        public int Codigo
        {
            get  { return codigo; }

            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public string Region
        {
            get { return region; }

            set { region = value; }
        }

        //metodos

    }
}
