using System;

namespace PracticaDos
{
     class PracticaDos 
    {
        static void Main(string[] args)
        {
            int Valor1;
            int Valor2;
            int resultado = 0;
            string continuar1 = null;
           NuevasFunciones Extra = new NuevasFunciones();
            do
            {

                Console.WriteLine("Ingrese el primer numero");
                Valor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                Valor2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Ingrese una opcion en la calculadora:");
                Console.WriteLine("(+) para sumar");
                Console.WriteLine("(-) para restar");
                Console.WriteLine("(*) para Multiplicar");
                Console.WriteLine("(P) para Potenciar los valores");
                Console.WriteLine("(S) para salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("el resultado de la suma es:");
                        resultado = FuncionesMatematicas.Suma(Valor1, Valor2);
                        Console.WriteLine("Su resultado es: " + resultado);
                        break;
                    case "-":
                        Console.WriteLine("el resultado de la resta es:");
                        resultado = FuncionesMatematicas.Resta(Valor1, Valor2);
                        Console.WriteLine("Su resultado es: " + resultado);
                        break;
                    case "*":
                        Console.WriteLine("el resultado de la multiplicacion es:");
                        resultado = FuncionesMatematicas.Multiplicacion(Valor1, Valor2);
                        Console.WriteLine("Su resultado es: " + resultado);
                        break;
                    case "P":
                        Console.WriteLine("el resultado de su potencia es:");
                        Extra.Potencia(Valor1, Valor2);
                        Console.WriteLine("\n");

                        break;
                    case "S":
                        Console.WriteLine("hasta la proxima");
                        Console.ReadKey();
                        break;

                }

                Console.WriteLine("Desea Continuar con la calculadora? Si/No");
                continuar1 = Console.ReadLine();

            } while (continuar1 == "Si" || continuar1 == "si");
            Console.ReadKey();


        }
    }

    class FuncionesMatematicas
    {
       public int Valor1;
       public int Valor2;

        public static int Suma(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 + valor2;
            return resultado;
        }
        public static int Resta(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 - valor2;
            return resultado;
        }
        public static int Multiplicacion(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 * valor2;
            return resultado;
        }

    }

    class NuevasFunciones : FuncionesMatematicas
    {
        public void Potencia(int Valor1, int Valor2)
        {
            double Cuadrado = Math.Pow(Valor1, Valor2);
            Console.WriteLine("Su numero {0} elevado por {1} es {2}", Valor1, Valor2, Cuadrado);
        }
    }
}

