using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empleado;
            double salario, horasTrabajadas, horasExtras,valorDia  , valorHorasTrabajadas  , auxilioTrnasporte ;
            double neto , valorHorasExtras, valorHora;
            bool respuesta = true;

            Console.Write(" desea realizar  una nomina ? (true o false): ");
            respuesta = Convert.ToBoolean(Console.ReadLine());



            while (respuesta==true)
            {
                Console.WriteLine("DIGITANOS POR FAVOR  TU NOMBRE");
                empleado = Console.ReadLine();
                Console.WriteLine("DIGITANOS POR FAVOR  TU SALARIO");
                salario =Convert.ToDouble ( Console.ReadLine());
                Console.WriteLine("DIGITANOS POR FAVOR  TUS HORAS TRABAJADAS");
                horasTrabajadas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("DIGITANOS POR FAVOR  TUS HORAS EXTRAS");
                horasExtras = Convert.ToDouble(Console.ReadLine());

                valorDia = salario / 30;
                valorHora = valorDia / 8;
                valorHorasTrabajadas = horasTrabajadas * valorHora;
                valorHorasExtras = horasExtras * valorHora * 1.25;


                if (salario <= 2000000)
                {
                    auxilioTrnasporte = 117000;
                }
                else 
                {
                    auxilioTrnasporte = 0;
                }

                neto = salario + auxilioTrnasporte + valorHorasExtras;
                

                Console.WriteLine("su nombre es  : " + empleado);
                Console.WriteLine("su salario es : "+ salario);
                Console.WriteLine("el valor del dia  es : " + valorDia);
                Console.WriteLine("el valor hora  es : " + valorHora);
                Console.WriteLine("el total de horas trabajadas es : " + horasTrabajadas);
                Console.WriteLine("el valor de horas trabajdas es  es : " + valorHorasTrabajadas);
                Console.WriteLine("el total de horas extras  es : " + horasExtras);
                Console.WriteLine("el valor de las horas extras es  : " + valorHorasExtras);
                Console.WriteLine("el auxilio de transporte es  " + auxilioTrnasporte);
                Console.WriteLine("el valor neto  : " + neto);


                Console.Write(" desea realizar  otra nomina ? (true o false): ");
                respuesta = Convert.ToBoolean(Console.ReadLine());




            }

        }
    }
}
