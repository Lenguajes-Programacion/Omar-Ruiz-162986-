using System;

namespace PracticaDos
{
    class PracticaDos
    {
        //Proyecto Calculadora
        //se espera recivir los argumentos valor1 (int) valor2(string) operador3()
        //valor 3 (int)
        // responder un resulado en int 
        
        
        static void Main(string[] args)
        {
            int Valor1;
            int Valor2;
            int R;
            string calculadora; 
            
            Console.WriteLine("Bienvenido, seleciona la funcion a ejecutar \n");
            Console.WriteLine("ingrese el primer numero");
            Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            Valor2 = Convert.ToInt32(Console.ReadLine());
           
            switch (calculadora)
            {
                case 1:
                    Console.WriteLine("Es una suma");
                    break;
                case 2:
                    Console.WriteLine("Es una Resta");
                    break;
                case 3:
                    Console.WriteLine("Es una Multiplicacion");
                    break;
                case 4:
                    Console.WriteLine("Es una Multiplicacion");
                    break;
                default:
                    Console.WriteLine("los argumentos no cuentan como operador valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
