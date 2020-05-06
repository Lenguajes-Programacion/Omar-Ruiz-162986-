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
            int resultado1 = 0;
            int resultado2 = 0;
            string continuar1 = null;
            string continuar2 = null;
            Memoria memoria = new Memoria();
            do
            {

                Console.WriteLine("Ingrese el primer numero");
                Valor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                Valor2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese una opcion en la calculadora");
                Console.WriteLine("(+) para sumar");
                Console.WriteLine("(-) para restar");
                Console.WriteLine("(*) para Multiplicar");
                Console.WriteLine("(M) para Memoria");
                Console.WriteLine("(MR) Borrar Memoria");
                Console.WriteLine("(S) para salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("el resultado de la suma es:");
                        resultado = Valor1 + Valor2;
                        Console.WriteLine("{0} + {1} = {2}", Valor1, Valor2, resultado);
                        Console.WriteLine("Desea Utilizar el resultado para una otra operacion? si/no");
                        continuar2 = Console.ReadLine();
                        _ = continuar2 == "si";
                        Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                        Console.WriteLine("Agregue un nuevo dato para sumar");
                        resultado1 = Convert.ToInt32(Console.ReadLine());
                        resultado2 = resultado + resultado1;
                        Console.WriteLine("el resultado es:" + resultado2);
                        break;
                    case "-":
                        Console.WriteLine("el resultado de la resta es:");
                        resultado = Valor1 - Valor2;
                        Console.WriteLine("{0} - {1} = {2}", Valor1, Valor2, resultado);
                        Console.WriteLine("Desea Utilizar el resultado para una otra operacion? si/no");
                        continuar2 = Console.ReadLine();
                        _ = continuar2 == "si";
                        Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                        Console.WriteLine("Agregue un nuevo dato para restar");
                        resultado1 = Convert.ToInt32(Console.ReadLine());
                        resultado2 = resultado - resultado1;
                        Console.WriteLine("el resultado es:" + resultado2);
                        break;
                    case "*":
                        Console.WriteLine("el resultado de la multiplicacion es:");
                        resultado = Valor1 * Valor2;
                        Console.WriteLine("{0} * {1} = {2}", Valor1, Valor2, resultado);
                        Console.WriteLine("Desea Utilizar el resultado para una otra operacion? si/no");
                        continuar2 = Console.ReadLine();
                        _ = continuar2 == "si";
                        Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                        Console.WriteLine("Agregue un nuevo dato para multiplicar");
                        resultado1 = Convert.ToInt32(Console.ReadLine());
                        resultado2 = resultado * resultado1;
                        Console.WriteLine("el resultado es:" + resultado2);
                        break;
                    case "P":
                        Console.WriteLine("Desea potenciar sus datos?");

                        break;

                    case "m":
                        Console.WriteLine("Accediendo a Memoria \n");
                        Console.WriteLine("-----------------\n");
                  
                        String key = Console.ReadLine();
                     
                        resultado = memoria.GetMemoriaData(key);
                 
                        Console.WriteLine(resultado);
                       
                        break;

                    case "mr":
                        Console.WriteLine("Memoria Temporal Reiniciada \n");
                        resultado = 0;
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
}

 
    
    
    
   
        
                      
    
                                      
         
