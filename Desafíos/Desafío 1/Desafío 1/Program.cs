using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarma a1 = new Alarma("111");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la clave: ");
                a1.ClaveIngreso = Console.ReadLine();
                if (a1.Verificador())
                {
                    i = 2; //TAMBIEN SE PUEDE USAR "break;" para salir del bucle/ciclo.
                    Console.WriteLine("ALARMA DESACTIVADA");

                }
                else
                {
                    Console.WriteLine("CLAVE INCORRECTA - VA " + (i + 1) + " DE 3 INTENTOS");

                }
            }
            Console.ReadKey();
                
            


            //Telefono t1 = new Telefono("14", "Iphone");
            //Console.WriteLine("Equipo: " + t1.Marca + " " + t1.Modelo);
            //Console.WriteLine();


            //Console.WriteLine("Ingrese el Código Operador: ");
            //t1.CodigoOperador = int.Parse(Console.ReadLine());

            //while (t1.CodigoOperador == 0)
            //{
            //    Console.WriteLine("CÓDIGO INCORRECTO");
            //    Console.WriteLine("Ingrese el Código Operador: ");
            //    t1.CodigoOperador = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(t1.Llamar());
            //Console.WriteLine(t1.Llamar("Carlos"));
            //Console.ReadKey();
        }
    }
}
