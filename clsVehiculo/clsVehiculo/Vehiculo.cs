using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsVehiculo
{
    internal class Vehiculo
    {
        private string placa;
        private string modelo;
        private string marca;
        private double precio;
        private string accesorios;

       

        //constructores

        public Vehiculo() { }
        public Vehiculo(string placa, string modelo, string marca, double precio, string accesorios)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Precio = precio;
            this.Accesorios = accesorios;
        }


        //encapsulamiento

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Accesorios { get => accesorios; set => accesorios = value; }


        //metodos

        public void  listadoVehiculos()
        {
            Console.WriteLine($"numero de placa : {Placa}\t modelo: {Modelo}\t marca : {Marca}\t precio : {Precio}\t acessorios: {Accesorios}\t");
        }

        public void Descuento( double descuento)
        {
            double valorDescuento , total;

            valorDescuento = Precio * descuento*100;

            total = precio - valorDescuento;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($" marca : {Marca}");
            Console.WriteLine($" modelo : {Modelo}");
            Console.WriteLine($" placa : {Placa}");
            Console.WriteLine($" precio : {Precio}");
            Console.WriteLine($" valor del descuento : {valorDescuento}");
            Console.WriteLine($" total : {total}");
            Console.WriteLine("----------------------------------------------");

        }


    }
}
