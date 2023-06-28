using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string confirmacion = "";
            do
            {
                int edadUno = 0;
                int edadDos = 0;
                bool esMayor = false;
                Console.WriteLine("Bienvenido");
                edadUno = Convert.ToInt32(LeerTeclado("Ingresa edad uno:"));
                edadDos = Convert.ToInt32(LeerTeclado("Ingresa edad dos:"));
                esMayor = ValidarEdad(edadUno, edadDos);

                if (esMayor)
                {
                    Console.WriteLine("La edad uno " + edadUno + " es mayor que la dos " + edadDos);
                }
                else
                {
                    Console.WriteLine("La edad uno " + edadUno + " es menor que la dos" + edadDos);

                }

                Console.Clear();
                
              
                confirmacion = LeerTeclado("Deseas ingresar dos numeros otra vez:");
            } while (confirmacion == "si");
            
          
            

        }
        public static string LeerTeclado(string mesaje)
        {
            string res = "";
            Console.Write(mesaje);
            res = Console.ReadLine();
            return res;
        }


        public static bool ValidarEdad(int edad1, int edad2)
        {
            bool res = false;
            if (edad1 > edad2)
            {
                res = true;
            }
            return res;
        }

        public static string Confirmacion()
        {
            string resp = "";
            Console.WriteLine("Deseas ingresar otros numeros:");
            resp=Console.ReadLine();
            return resp;
        }

    }
}
