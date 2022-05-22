using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simon = new Empleado(123,"simon", " 3045239673","parque de belen ",1500000);
            var sofia = new Empleado(124, "juanita", " 30452559673", "belen playas ", 1200000);
            //crear un objeto vacio 

            /*var salome = new Empleado();
            salome.IdEmpleado = 258;
            salome.Nombre = "salome";
            salome.Salario = 2500000;
            salome.Direccion = "belen san bernardo";
            salome.NumeroCelular = 2500000;

            salome.listarEmpleado();*/

            simon.listarEmpleado();
            sofia.listarEmpleado();

            simon.calcularNomina();
            sofia.calcularNomina();

            

            Console.ReadKey();
        }
    }
}
