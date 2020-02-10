using System;
namespace PracticaDos
{
    class PracticaDos
    {
        public static void Main(string[] args)
        {
            int Valor1;
            int Valor2;
            int resultado;
            string continuar = null;

            Console.WriteLine("Ingrese el primer numero");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese una opcion en la calculadora");
            Console.WriteLine("(+) para sumar");
            Console.WriteLine("(-) para restar");
            Console.WriteLine("(*) para Multiplicar");
            Console.WriteLine("(S) para salir");
            string opcion = Console.ReadLine();

            do
            {
                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("el resultado de la suma es:");
                        resultado = Valor1 + Valor2;
                        Console.WriteLine("{0} + {1} = {2}", Valor1, Valor2, resultado);
                        break;
                    case "-":
                        Console.WriteLine("el resultado de la resta es:");
                        resultado = Valor1 - Valor2;
                        Console.WriteLine("{0} - {1} = {2}", Valor1, Valor2, resultado);
                        break;
                    case "*":
                        Console.WriteLine("el resultado de la suma es:");
                        resultado = Valor1 * Valor2;
                        Console.WriteLine("{0} * {1} = {2}", Valor1, Valor2, resultado);
                        break;
                    case "S":
                        Console.WriteLine("hasta la proxima");
                        Console.ReadKey();
                        break;

                }
                Console.WriteLine("Desea Continuar con la calculadora? Si/No");
                continuar = Console.ReadLine();

            } while (continuar == "Si" || continuar == "si");
            Console.ReadKey();
        }
    }
}
