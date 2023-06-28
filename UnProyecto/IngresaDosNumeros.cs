using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnProyecto
{
    public class IngresaDosNumeros
    {
        public static void MyMetodo()
        {
            int numero1 = 0;
            int numero2 = 0;
            Console.WriteLine("Ingresa un numero:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa un numero:");
            numero2= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (numero1>numero2)
            {
                Console.WriteLine(numero1+" "+" es mayor que:"+" "+numero2);
            }
        }


    }

  





}

