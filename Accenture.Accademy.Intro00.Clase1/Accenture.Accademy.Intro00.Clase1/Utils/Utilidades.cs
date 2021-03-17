using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accenture.Accademy.Intro00.Clase1.Utils
{
    public class Utilidades
    {
        public static int ReadInt()
        {
            int numero;

            string entrada = Console.ReadLine();
            while (!Int32.TryParse(entrada, out numero))
            {
                Console.WriteLine("No ingreso un numero. Vuelva a intentarlo!");
                entrada = Console.ReadLine();
            }
            return numero;
        }
    }
}
