using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroSemana;

            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│Desarrollador.Simon Clavijo Gutierrez       │");
            Console.WriteLine("│Correo. simonclagutierrez@gmail.com         │");
            Console.WriteLine("│Celular.3045239673                          │");
            Console.WriteLine("│────────────────────────────────────────────│");
            Console.WriteLine("│instruccion en caso                         │");
            Console.WriteLine("│Enero 24 de 2022                            │");
            Console.WriteLine("│CESDE **** CONFAMA                          │");
            Console.WriteLine("└────────────────────────────────────────────┘");

            Console.WriteLine("digite el nuemero de semana");
            numeroSemana = Convert.ToInt16(Console.ReadLine());

            switch (numeroSemana)
            {

                case 1:
                    {
                        Console.WriteLine("lunes");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("martes");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("miercoles");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("jueves");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("viernes");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("sabado");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("domingo");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("error en el numero de la semana ....");
                        break;
                    }





            }


            Console.ReadKey();  

        }
    }
}
