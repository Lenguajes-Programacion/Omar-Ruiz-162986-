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

                    case "M":
                        Memoria memo = new Memoria();
                        memo.GuardadMemoria();
                        //crear metodo que nos regrese el resultado seleccionado
                        // utilizar el resultado en una nueva operacion
                        // Guardad la nueva operacion en nuestra db.json
                        Console.WriteLine("Desea utilizar alguno de los datos guardados?");
                        string ArchivoDB = "../../../db.json";
                        memoria.arreglo();


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
