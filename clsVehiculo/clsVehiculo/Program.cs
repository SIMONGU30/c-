using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsVehiculo
{
    internal class Program
    {
        static void Main(string[] args)

        {

            double descuento;

            Console.WriteLine("---------------VEHICULOS--------------------");
            var mazda = new Vehiculo("abc123", "2020", "mazda", 45000000, "si");
            var chevrolet = new Vehiculo("abc465", "2021", "chevrolet", 35000000, "no");

            Console.WriteLine("---------------LISTADOS------------------------");
            mazda.listadoVehiculos();
            chevrolet.listadoVehiculos();

            Console.WriteLine("---------------------DESCUENTO------------------");

            Console.WriteLine("digite el descuento asi : 7 si es el 7%");
            descuento= Convert.ToDouble(Console.ReadLine());

            mazda.Descuento(descuento);
            chevrolet.Descuento(descuento);


            Console.ReadKey();


        }
    }
}
