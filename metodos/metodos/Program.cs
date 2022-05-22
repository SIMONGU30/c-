using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Program

    {

        static void saludar()
        {
            Console.WriteLine("hola baby");
        }

        static void saludarNombre(string nombre)
        {
            Console.WriteLine("hola .... " +  nombre + "  como estas");
        }

        static double calcularNomina(double salario, double numeroHoras)
        {
            double valorDia, valorHora, auxilioTransporte;
            double netoPagar, netoPagar2;

            valorDia = salario / 30;
            //Console.WriteLine("el valor del dia es : " +
            //"" + valorDia);
            valorHora = valorDia / 8;
            // Console.WriteLine("el valor de la hora es : " + valorHora);
            //auxilioTransporte = 117000;
            // Console.WriteLine(" el auxilio de transpote es " + auxilioTransporte);

            auxilioTransporte = 117000;
            netoPagar2 = numeroHoras * valorHora;
            netoPagar = numeroHoras * valorHora + auxilioTransporte;
            Console.WriteLine("el salario es de : " + salario);
            Console.WriteLine(" el auxilio de transporte es de : "+auxilioTransporte);
            Console.WriteLine(" el salario neto es de : " + netoPagar2);
            Console.WriteLine("el neto + el auxilio es : "+netoPagar);

            return netoPagar;
        }
        static void Main(string[] args)
        {
           // double netoPagar ;
            /* saludar();  
            saludarNombre("jomar");

            Console.WriteLine("neto a pagar " + calcularNomina(1000000, 120));

            auxiloTransporte = 117000;*/
            //netoPagar = calcularNomina(1500000, 250);

            calcularNomina(1500000, 250);
         
            Console.ReadKey();
        }
    }
}
