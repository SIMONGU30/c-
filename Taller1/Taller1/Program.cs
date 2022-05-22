using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
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
            Console.WriteLine("│EJERCICIO PARA LA CASA EN C#                │");
            Console.WriteLine("│Enero 24 de 2022                            │");
            Console.WriteLine("│CESDE **** CONFAMA                          │");
            Console.WriteLine("└────────────────────────────────────────────┘");

            /* CREAR UN ALGORITMO QUE LE PERMITA AL USUARIO INGRESAR 3 NÚMEROS 
             * Y EL COMPUTADOR LE MUESTRE CUAL ES EL MAYOR */


             
           

            string nombre;
            int numero1, numero2, numero3 , mayor;

            Console.WriteLine("********************** BUENAS TARDES**********************");
            Console.WriteLine("POR FAVOR DIGITE SU NOMBRE : ");
            nombre = Console.ReadLine();
            Console.WriteLine("POR FAVOR DIGITE EL PRIMER NUMERO : ");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("POR FAVOR DIGITE EL SEGUNDO NUMERO : ");
            numero2 =Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("POR FAVOR DIGITE EL TERCER NUMERO : ");
            numero3 = Convert.ToInt16(Console.ReadLine());

            
            if(numero1 < numero2 && numero2 <numero3)
            {
                mayor = numero3;
            }

            else
            {
                if (numero2 <numero1 && numero2 < numero3)
                {
                    mayor = numero1;
                }
                else
                {
                    mayor = numero2;
                }
            }

            Console.Write(nombre + " EL MAYOR ES :  " + mayor);

            Console.ReadKey();




        }
    }
}
