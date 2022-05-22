using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras_Geometricas
{
    internal class Program
    {

        static void Informacion()
        {
            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│Desarrollador.Edinson Mesa                  │");
            Console.WriteLine("│Desarrollador.Jovany Lopez Zapata           │");
            Console.WriteLine("│Desarrollador.Simon Clavijo Gutierrez       │");
            Console.WriteLine("│────────────────────────────────────────────│");
            Console.WriteLine("│**TALLER ** Figuras  Geometricas            │");
            Console.WriteLine("│Febrero 21 de 2022                          │");
            Console.WriteLine("│CESDE **** CONFAMA                          │");
            Console.WriteLine("└────────────────────────────────────────────┘");

        }

        static void Menu()
        {
            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│1.TRIANGULO                                 │");
            Console.WriteLine("│2.CUADRADO                                  │");
            Console.WriteLine("│3.RECTANGULO                                │");
            Console.WriteLine("│4.CIRCULO                                   │"  );
            Console.WriteLine("│5.ROMBO                                     │");
            Console.WriteLine("│6.PENTAGONO                                 │");
            Console.WriteLine("│7.HEXAGONO                                  │");
            Console.WriteLine("│8.TRAPECIO                                  │");
            Console.WriteLine("│9.PARALELOGRAMO                             │");
            Console.WriteLine("│10. ***********SALIR***********             │");
            Console.WriteLine("└────────────────────────────────────────────┘");

        }
        static void Main(string[] args)
        {
            int opcion=0;
            double lado1,lado2, lado3,lado4,diametroH,diametroV;
            double basee,altura,radio,apotema,basemayor,basemenor;

            Informacion();

            do
            {
                Menu();
                Console.WriteLine("Digite la opcion que desea del menu.");
                opcion = Convert.ToInt32(Console.ReadLine());
                var triangulo = new CalcularFiguras();
                var cuadrado = new CalcularFiguras();
                var rectangulo = new CalcularFiguras();
                var circulo = new CalcularFiguras();
                var rombo = new CalcularFiguras();
                var pentagono = new CalcularFiguras();
                var hexagono = new CalcularFiguras();
                var trapecio = new CalcularFiguras();
                var paralelogramo = new CalcularFiguras();
                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("Digite el valor del lado 1 del triangulo");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado 2 del triangulo");
                        lado2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado 3 del triangulo");
                        lado3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del la altura del triangulo");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del la base del triangulo");
                        basee = Convert.ToDouble(Console.ReadLine());
                        triangulo.Triangulo(lado1 , lado2, lado3 ,basee,altura);

                        break;
                    case 2:
                        Console.WriteLine("Digite el valor del lado del cuadrado");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        cuadrado.Cuadrado(lado1);

                        break;
                    case 3:
                        Console.WriteLine("Digite el valor del la base del rectangulo ");
                        basee = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del la altura del rectangulo ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        rectangulo.Rectangulo(basee,altura);

                        break;
                    case 4:
                        Console.WriteLine("Digite el valor del Radio del circulo");
                        radio = Convert.ToDouble(Console.ReadLine());
                        circulo.Circulo(radio);
                     
                        break;
                    case 5:
                        Console.WriteLine("Digite el valor del diametro horizontal del Rombo ");
                        diametroH = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el el valor del diametro vertical del Rombo ");
                        diametroV = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del  lado del Rombo ");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        rombo.Rombo(diametroH, diametroV, lado1);

                        break;
                    case 6:
                        Console.WriteLine("Digite el valor de la apotema del Pentagono ");
                        apotema = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado del Pentagono ");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        pentagono.Pentagono(apotema,lado1);

                        break;
                    case 7:
                        Console.WriteLine("Digite el valor de la apotema del Hexagono ");
                        apotema = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado del Hexagono ");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        hexagono.Pentagono(apotema, lado1);

                        break;
                    case 8:
                        Console.WriteLine("Digite el valor del  lado 1 del Trapecio ");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado 2 del Trapecio ");
                        lado2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado 3 del Trapecio  ");
                        lado3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado 4 del Trapecio ");
                        lado4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor de la base mayor del Trapecio ");
                        basemayor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del la base menor del Trapecio ");
                        basemenor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor de la altura del Trapecio ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        trapecio.Trapecio(lado1,lado2,lado3,lado4,basemayor,basemenor,altura);

                        break;
                    case 9:
                        Console.WriteLine("Digite el valor de la altura del Paralelogramo ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del lado del Paralelogramo ");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite el valor del la base del Paralelogramo ");
                        basee = Convert.ToDouble(Console.ReadLine());

                        paralelogramo.Paralelogramo(altura,lado1,basee);
                     
                        break;
                    case 10:
                        Console.WriteLine("FIN DEL PROGRAMA,HASTA PRONTO...");
                        break;
                }
            } while (opcion != 10);

            Console.ReadKey();

        }
    }
}
