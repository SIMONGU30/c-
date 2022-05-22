using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cEmpleado
{
    internal class Empleado
    {
        // PASO1 : definir propiedades 

        private int idEmpleado;
        private string nombre;
        private string numeroCelular;
        private string direccion;
        private int salario;

        // PASO 2 : contructores


        // PASO2.1: CONSTRUCTOR GENERAL
        public Empleado() { }

        public Empleado(int idEmpleado, string nombre, string numeroCelular, string direccion)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.NumeroCelular = numeroCelular;
            this.Direccion = direccion;
        }

        // PASO2.2: CONSTRUCTOR CON PARAMETROS
        public Empleado(int idEmpleado, string nombre, string numeroCelular, string direccion, int salario)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.NumeroCelular = numeroCelular;
            this.Direccion = direccion;
            this.Salario = salario;
        }
        //PASO 3 : ENCAPSULAR
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Salario { get => salario; set => salario = value; }


        // PASO 4 : definir metodos 
        public void calcularNomina()
        {
            double valorDia, valorHora;
            valorDia = Salario / 30;
            valorHora = valorDia / 8;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"          liquidacion nomina para {Nombre}");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"cedula : {IdEmpleado}");
            Console.WriteLine($"nombre : {Nombre}");
            Console.WriteLine($"salario : {Salario}");
            Console.WriteLine($"valor dia : {valorDia}");
            Console.WriteLine($"valor hora : {valorHora}");
        }

        public void listarEmpleado( )
        {
            Console.WriteLine($"celular : {IdEmpleado}  \t nombre:{nombre} \t numero Celular:{ numeroCelular} \t direccion:{direccion} \t salario :{salario}"); 
           

        }

        





    }
}
