using System; //importarmos la libreria principal


namespace Practica_1
{
   public class Program
    {
       static string name = "omar";
        static void Main(string[] args) //primera funcion que correra
        {
            //condicion se debe de cumplir las sentencias que utilizamos &&
            //condicion se debe de cumplir las sentencias que utilizamos ||
            // >< == = 
            if (args[0].Length > 0 && args[0] == name)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("saquese");
            }

            
            Console.ReadKey();
        }
       
    }
}
