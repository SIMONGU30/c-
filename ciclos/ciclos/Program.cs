using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│Desarrollador.Simon Clavijo Gutierrez       │");
            Console.WriteLine("│Correo. simonclagutierrez@gmail.com         │");
            Console.WriteLine("│Celular.3045239673                          │");
            Console.WriteLine("│────────────────────────────────────────────│");
            Console.WriteLine("│ciclos                                      │");
            Console.WriteLine("│Enero 24 de 2022                            │");
            Console.WriteLine("│CESDE **** CONFAMA                          │");
            Console.WriteLine("└────────────────────────────────────────────┘");

            /* int numero, i;

           Console.WriteLine("digite un numero : ");
           numero = Convert.ToInt16(Console.ReadLine());

           for (i = 1; i < 10; i++)
           {
               Console.WriteLine(numero + "*"+ i + "=" + numero*i);
           }


           Console.ReadKey(); */



            /* int numero  ,  i=1 ;

             Console.WriteLine(" digite el numero a multiplicar : ");
             numero = Convert.ToInt16(Console.ReadLine());

             while (i <= 10)
             {
                 Console.WriteLine(numero + "*" + i + "=" + numero * i);

                 i ++;
             }
             Console.ReadKey(); */


            int numero,i;
            bool respuesta = true;

            

            while (respuesta == true)
            {
                Console.WriteLine(" digite el numero a multiplicar : ");
                numero = Convert.ToInt16(Console.ReadLine());
                i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(numero + "*" + i + "=" + numero * i);

                    i++;
                }
                Console.Write(" desea realizar  otra multiplicacion (true o false): ");
                respuesta= Convert.ToBoolean(Console.ReadLine());

            }

            Console.ReadKey();

        }
    }
}
