using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLibro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------LIBROS------------------");
            var gatoConBotas = new Clase_libro(456, "El gato con botas", 20, 2);
            var ratonPerez = new Clase_libro(123, "El raton Perez ", 2, 0);
           

            Console.WriteLine("-------------------- INVENTARIO-----------------");
            gatoConBotas.prestarLibro();
            ratonPerez.prestarLibro();
            ratonPerez.prestarLibro();
            ratonPerez.prestarLibro();


            Console.ReadKey();
        }
    }
}
