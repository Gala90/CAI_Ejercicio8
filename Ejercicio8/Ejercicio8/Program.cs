using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            DateTime date1;
          

            Console.WriteLine("Ingrese una fecha en formato DD/MM/AAAA: ");
            dato = Console.ReadLine();

            date1 = Convert.ToDateTime(dato);

                                  
            DateTime fechaHoy = DateTime.Now;

        
            TimeSpan t = date1 - fechaHoy;
            int NrOfDays = t.Days;

            Console.WriteLine(NrOfDays);


            Console.ReadKey();
        }
    }
}
