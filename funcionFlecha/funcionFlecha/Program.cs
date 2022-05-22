using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionFlecha
{
    internal class Program
    {
        static void saludar()=> Console.WriteLine("hola amigo ");
        static void saludar(string nombre) => Console.WriteLine("hola amigo "+nombre);



        static void Main(string[] args)
        {
            string nom;

            Console.WriteLine("digte su nombre");
            nom = Console.ReadLine();
            saludar();
            saludar(nom);

            Console.ReadKey();
        }
    }
}
