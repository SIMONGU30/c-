using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLibro
{
    internal class Clase_libro
    {
        private int isbn;
        private string nombre;
        private int cantidadLibros;
        private int numeroLibrosPrestados;

        public Clase_libro(int isbn, string nombre, int cantidadLibros, int numeroLibrosPrestados)
        {
            this.Isbn = isbn;
            this.Nombre = nombre;
            this.CantidadLibros = cantidadLibros;
            this.NumeroLibrosPrestados = numeroLibrosPrestados;
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CantidadLibros { get => cantidadLibros; set => cantidadLibros = value; }
        public int NumeroLibrosPrestados { get => numeroLibrosPrestados; set => numeroLibrosPrestados = value; }
public void prestarLibro()
        {
            int prestados;

            if (CantidadLibros>0)
            {
                prestados = CantidadLibros - NumeroLibrosPrestados;

                

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"ID libro : {Isbn} ");
                Console.WriteLine($"NOMBRE: {Nombre} ");
                Console.WriteLine($"CANTIDAD: {CantidadLibros} ");
                Console.WriteLine($"PRESTADOS: {NumeroLibrosPrestados} ");
                Console.WriteLine($"DISPONIBLES: {prestados} ");
                Console.WriteLine("---------------------------------------------");

                CantidadLibros = CantidadLibros - 1;
                numeroLibrosPrestados= numeroLibrosPrestados+1; 


            }
            else {

              

                Console.WriteLine("del libro" + Nombre + " no hay disponibles.....");

                
            }
            
               
            

           




            
        }

    }
}
