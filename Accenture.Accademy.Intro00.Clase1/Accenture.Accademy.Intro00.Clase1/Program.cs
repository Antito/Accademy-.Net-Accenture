using Accenture.Accademy.Intro00.Clase1.Models;
using Accenture.Accademy.Intro00.Clase1.Utils;
using System;
using System.Collections.Generic;

namespace Accenture.Accademy.Intro00.Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> avengers = new List<Character>();

            //Console.WriteLine("Hello World!");
            Character ironMan = new Character()
            {
                Alias = "Iron Man",
                Nombre = "Tony Stark",
                Edad = 49
            };


            //ironMan.Alias = "Iron Man";
            //ironMan.Nombre = "Tony Stark";

            //ironMan.Poderes poderes = new ironMan.Poderes(); no se puede porque no hay set 

            ironMan.Poderes.Add("Super inteligencia");
            ironMan.Poderes.Add("Ser asquerosamente millonario");
            avengers.Add(ironMan);

            Character spiderMan = new Character()
            {
                Alias = "Spider Man",
                Nombre = "Peter Parker",
                Edad = 16
            };

            spiderMan.Poderes.Add("Instinto aracnido");
            spiderMan.Poderes.Add("Telaraña");
            avengers.Add(spiderMan);

            Character nuevoPersonaje = new Character();
            Console.WriteLine("Hola Bienvenido a la iniciativa Avengers");
            Console.WriteLine("Como se llama el nuevo Avenger?");
            nuevoPersonaje.Nombre = Console.ReadLine();
            Console.WriteLine("Cual es su Alias?");
            nuevoPersonaje.Alias = Console.ReadLine();


            Console.WriteLine("Cual es su Edad?");
            nuevoPersonaje.Edad = Utilidades.ReadInt();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Que poder tiene?");
                nuevoPersonaje.Poderes.Add(Console.ReadLine());
                Console.WriteLine("Tiene otro poder? (S/N) ");
                //ConsoleKeyInfo opcion = Console.ReadKey();
                
            } while (Console.ReadKey(true).Key == ConsoleKey.S); //da igual que sea may o min, con el ReadKey(true) --> no muestra la letra

            
            avengers.Add(nuevoPersonaje);
            //foreach (Chracter avenger in avengers)
            foreach (var avenger in avengers)
            {
                //Console.WriteLine($"{avenger.Nombre} alias {avenger.Alias} de edad {avenger.Edad}"); //$ permite concatenar variables
                Console.WriteLine(avenger);
                //Console.WriteLine(avenger.Nombre);
                //Console.WriteLine(avenger.Alias);
                //Console.WriteLine(avenger.Edad);
                foreach (var poder in avenger.Poderes)
                {
                    Console.WriteLine($"Su poder es: {poder} ");
                }
                
            }


            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para finalizar..");
            Console.ReadKey();
        }
    }
}
