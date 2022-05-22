using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras_Geometricas
{
    internal class CalcularFiguras
    {

        private double perimetro;
        private double area;

        public double Perimetro { get => perimetro; set => perimetro = value; }
        public double Area { get => area; set => area = value; }

        public CalcularFiguras() { }

        

        public void Triangulo(double lado1, double lado2, double lado3, double basee , double altura)
        {
            Perimetro = lado1 + lado2 + lado3;
            Area = basee * altura / 2;
            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  TRIANGULO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Cuadrado(double lado)
        {
            Perimetro = lado * 4;
            Area = lado * lado;

            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  CUADRADO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Rectangulo(double basee,double altura)
        {
            Perimetro = (altura * 2) + (basee * 2);
            Area = basee * altura;

            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  RECTANGULO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Circulo(double radio)
        {
            double diametro;
            const double PI = 3.14;
            diametro = radio * 2;
            Perimetro = diametro * PI;
            Area = (radio * radio) * PI  ;
            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  CIRCULO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Rombo(double diametroHorizontal,double diametroVertical, double lado)
        {
            Perimetro = lado * 4;
            Area = diametroHorizontal*diametroVertical/2;

            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  ROMBO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Pentagono( double apotema, double lado)
        {
            Perimetro = lado * 5;
            Area = Perimetro*apotema / 2;

            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  PENTAGONO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Hexagono(double apotema, double lado)
        {
            Perimetro = lado * 6;
            Area = Perimetro * apotema / 2;
            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  HEXAGONO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Trapecio(double lado1, double lado2, double lado3, double lado4, double baseMayor, double baseMenor, double altura)
        {
            Perimetro = lado1 + lado2 + lado3+lado4;
            Area = (baseMayor*baseMenor) * altura / 2;

            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  TRAPECIO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }
        public void Paralelogramo(double ladoA, double basee, double altura)
        {
            Perimetro = (ladoA * 2) + (basee * 2);
            Area = basee * altura;

            Console.WriteLine($"┌─────────────────────────┐");
            Console.WriteLine($"    **  PARALELOGRAMO **      ");
            Console.WriteLine($"    PERIMETRO : {Perimetro}  ");
            Console.WriteLine($"    AREA : {Area}            ");
            Console.WriteLine($"└─────────────────────────┘");
        }




    }
}
