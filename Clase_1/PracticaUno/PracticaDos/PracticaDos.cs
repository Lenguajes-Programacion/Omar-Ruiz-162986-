using System;

namespace PracticaDos
{
    class PracticaDos
    {
        //Proyecto Calculadora
        //se espera recivir los argumentos valor1 (int) valor2(string) operador3()
        //valor 3 (int)
        // responder un resulado en int 
        
        
       public static void Main(string[] args)
        {
            int Valor1;
            int Valor2;
            int resultado;
            string opcion;

            Console.WriteLine("Ingrese el primer numero");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese una opcion en la calculadora");
            Console.WriteLine("(+) para sumar");
            Console.WriteLine("(-) para restar");
            Console.WriteLine("(*) para Multiplicar");
            Console.WriteLine("(/) para Dividir");
            opcion = Console.ReadLine();
            
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
                case "/":
                    Console.WriteLine("el resultado de la suma es:");
                    resultado = Valor1 / Valor2;
                    Console.WriteLine("{0} / {1} = {2}", Valor1, Valor2, resultado);
                    break;
            }
            Console.ReadKey();
        }
    }
}
