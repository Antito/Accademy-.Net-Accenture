using System;
using System.Collections.Generic;
using EducacionIT;

namespace Accenture2
{
    class Program
    {
        static void Main(string[] args)
        {
            //asignar notaTP
            Alumno.NotaTP = 5;

            EducacionIT.Pais PaisArg = new EducacionIT.Pais(); //instancio el objeto
            //PaisArg.Codigo = 54;
            //PaisArg.Nombre = "Argentina";
            //PaisArg.Region = "LATAM";

            EducacionIT.Pais PaisVenezuela = new EducacionIT.Pais(); //instancio el objeto
            PaisVenezuela.Codigo = 593;
            PaisVenezuela.Nombre = "Venezuela";
            PaisVenezuela.Region = "LATAM";

            Pais PaisUruguay = new Pais(580, "Uruguay", "LATAM"); 


            //Intancia del alumno!!

            Alumno objAlumno = new Alumno();
            objAlumno.Dni = 41079100;
            objAlumno.Apellido = "Buono";
            objAlumno.Nombre = "Antonella";
            objAlumno.Pais = PaisArg;
            objAlumno.Nota = 8;

            //creo un objeto de la clase telefono
            Telefono tel1 = new Telefono
            {
                Numero = 154333,
                Tipo = "Celular",
                Comp = "Personal"
            };

            Telefono tel2 = new Telefono
            {
                Numero = 123456,
                Tipo = "Laboral",
                Comp = "Movistar"
            };

            List<Telefono> lista = new List<Telefono>();
            lista.Add(tel1);
            lista.Add(tel2);

            //asigno a la prop Telefonos el alumno
            objAlumno.Telefonos = lista;

            //mostrar datos
            Console.WriteLine(Saludo.Saludar("Hola" , objAlumno.Nombre)); //lo puedo usar en cualquier lado

            Console.WriteLine("Datos del alumno {0} ", objAlumno.TraerDatos()); //{0} te coloca el texto ahi, evita concatenar 

            //mostrar Telefonos (Foreach)
            Console.WriteLine("Telefonos");
            foreach (var tel in objAlumno.Telefonos)
            {
                Console.WriteLine(tel.Numero +" Tipo: "+ tel.Tipo + " Compañia: "+ tel.Comp);
            }

            Alumno objAlum2 = new Alumno();
            objAlum2.Dni = 42555333;
            objAlum2.Apellido = "Cordoba";
            objAlum2.Nombre = "Sofia";
            objAlum2.Pais = PaisArg;
            objAlum2.Nota = 10;

            Console.WriteLine(Saludo.Saludar("Hello", objAlum2.Nombre)+ " " + objAlum2.TraerDatos());

            //pausa

            Console.ReadKey(); //cierra la ejecucion

        }
    }
}
