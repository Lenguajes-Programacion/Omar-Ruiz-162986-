using System; //importarmos la libreria principal


namespace Practica_1
{
   public class Program
    {
       static string name = "Omar";
         
        static void Main(string[] args) 
        {
            Console.WriteLine("Dinos cual es tu nombre");
            name = Console.ReadLine();

            if ( name == "Omar")
            {
                
                Console.WriteLine("Mi loco Dale pa dentro");
            }
            else
            {
                Console.WriteLine("saquese no eres omar");
            }

            
            Console.ReadKey();
        }
       
    }
}
