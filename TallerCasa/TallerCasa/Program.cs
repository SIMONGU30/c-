using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCasa
{
    internal class Program
    {

        static void informacionPersonal()
        {
            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│Desarrollador.Simon Clavijo Gutierrez       │");
            Console.WriteLine("│Correo. simonclagutierrez@gmail.com         │");
            Console.WriteLine("│Celular.3045239673                          │");
            Console.WriteLine("│────────────────────────────────────────────│");
            Console.WriteLine("│Programa Para Encontrar NotaDefinitiva      │");
            Console.WriteLine("│Febrero 7 de 2022                           │");
            Console.WriteLine("│CESDE **** CONFAMA                          │");
            Console.WriteLine("└────────────────────────────────────────────┘");
        }

        static double hallarNotas(double nota1 , double nota2, double nota3)
        {
            double notaDefinitiva, porcentaje1, porcentaje2, porcentaje3;

            porcentaje1 = nota1 *  20 / 100;
            porcentaje2 = nota2 *  30 / 100;
            porcentaje3 = nota3 * 50 / 100;

            notaDefinitiva = porcentaje1 + porcentaje2 + porcentaje3;



            return notaDefinitiva;
        }

        static void mensaje(double notaDefinitiva)
        {
            if(notaDefinitiva > 30 && notaDefinitiva < 50)
            {
                Console.WriteLine(" ***************** FELICITACIONES GANO ***************** ");
            }
            else
            {
                Console.WriteLine("****************** DEBES DE MEJORAR , PERDISTE ************** ");
            }
        }
        static void Main(string[] args)
        {

            double nota1, nota2, nota3;
            double notaDefinitiva;
            bool respuesta = true;


            informacionPersonal();

            while (respuesta == true)
            {
                Console.WriteLine("┌──────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│*********************** Buenas Trdes ***********************  │");
                Console.WriteLine("│Digite por favor la Primera Nota (CONOCIMIENTO 20%)           │"); nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("│Digite por favor la Segunda Nota (DESEMPEÑO 30%)              │"); nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("│Digite por favor la Tercera Nota (PRODUCTO 50%)               │"); nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("└──────────────────────────────────────────────────────────────┘");

                notaDefinitiva = hallarNotas(nota1, nota2, nota3);

                Console.WriteLine("la nota definitiva es : " + notaDefinitiva);
                mensaje(notaDefinitiva);


                Console.Write(" desea realizar  otra multiplicacion (true o false): ");
                respuesta = Convert.ToBoolean(Console.ReadLine());

            }

            Console.ReadKey();
        }
    }
}
