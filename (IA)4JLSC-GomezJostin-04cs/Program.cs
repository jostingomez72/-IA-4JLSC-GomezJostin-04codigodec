using System;

namespace _4JLSC_GomezJostin_04cs
{
    // Clase padre (abstracta)
    abstract class FiguraGeometrica
    {
        public abstract string Descripcion();
        public abstract double Area();
    }

    // Clase hija: Triángulo
    class Triangulo : FiguraGeometrica
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override string Descripcion()
        {
            return "Figura geométrica: Triángulo";
        }

        public override double Area()
        {
            return (baseTriangulo * altura) / 2;
        }
    }

    // Clase hija: Círculo
    class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Descripcion()
        {
            return "Figura geométrica: Círculo";
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    // Clase hija: Cuadrilátero
    class Cuadrilatero : FiguraGeometrica
    {
        private double baseCuadrilatero;
        private double altura;

        public Cuadrilatero(double baseCuadrilatero, double altura)
        {
            this.baseCuadrilatero = baseCuadrilatero;
            this.altura = altura;
        }

        public override string Descripcion()
        {
            if (baseCuadrilatero == altura)
            {
                return "Figura geométrica: Cuadrado";
            }
            else
            {
                return "Figura geométrica: Cuadrilátero";
            }
        }

        public override double Area()
        {
            return baseCuadrilatero * altura;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menú de Figuras Geométricas ===");
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Cuadrilátero");
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            FiguraGeometrica figura = null;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("=== Triángulo ===");
                    Console.Write("Ingresa la base: ");
                    double baseT = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura: ");
                    double alturaT = double.Parse(Console.ReadLine());
                    figura = new Triangulo(baseT, alturaT);
                    break;

                case 2:
                    Console.WriteLine("=== Círculo ===");
                    Console.Write("Ingresa el radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    figura = new Circulo(radio);
                    break;

                case 3:
                    Console.WriteLine("=== Cuadrilátero ===");
                    Console.Write("Ingresa la base: ");
                    double baseC = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura: ");
                    double alturaC = double.Parse(Console.ReadLine());
                    figura = new Cuadrilatero(baseC, alturaC);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (figura != null)
            {
                Console.WriteLine("\n" + figura.Descripcion());
                Console.WriteLine("Área: " + figura.Area());
            }

            Console.ReadLine();
        }
    }
}
