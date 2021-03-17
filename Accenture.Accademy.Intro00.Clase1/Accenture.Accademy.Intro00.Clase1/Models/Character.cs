using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accenture.Accademy.Intro00.Clase1.Models
{
    public class Character
    {
        //private string _nombre; si quiero añadir codigo lo hago asi
        //public string Nombre
        //{
        //    get
        //    {
        //        return this._nombre.ToUpper();
        //    }

        //    set
        //    {
        //        if(value.Length > 0)
        //        {
        //            _nombre = value;
        //        }

        //    }
        //}

        public string Nombre { get; set; }
        public string Alias { get; set; }

        public int Edad { get; set; } //es solo un ejemplo nunca usarlo asi!! se calcula

        public List<String> Poderes { get; } //no se va a poder instanciar en Program sin el set 

        public Character() 
        {
            this.Poderes = new List<String>();
           
        }

        public override string ToString()
        {
            return $"{this.Nombre} alias {this.Alias} de edad {this.Edad}";
        }
    }
}
