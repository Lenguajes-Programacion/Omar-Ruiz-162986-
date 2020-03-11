using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace PracticaDos
{
    class Memoria
    {
        public void GuardadMemoria()
        {

            string ArchivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(ArchivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //Prueba de lectura de archivo db
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();

            //lectuea de json iterable
            foreach (var item in dbObject)
            {
                Console.WriteLine("dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(item.Key, item.Value["operacion"].ToString(), (float)item.Value["resultado"]);
                Console.WriteLine("{0 - {1}", memoriaData.fecha.ToLongDateString());
                Console.WriteLine(memoriaData.fecha.ToLongDateString());
                Console.WriteLine(memoriaData.resultado.ToString());
                Console.WriteLine("\n");
            }
        }

        public void arreglo()
        {
            string[] Colores = { "Rojo", "Blanco", "morado" };
            //List<string> colores = ["Rojo", "Blanco", "morado"];
            //colores.Sort();
            Array.Sort(Colores);
            Array.ForEach(Colores, (item) => {
                Console.WriteLine(item);
            });
            String color = Array.Find(Colores, (item) => {
                return item.Length > 4; // el == es para poder comparar cada elemento con los de la lista
            });
            Console.WriteLine(color);
            Console.WriteLine("Accede tus colores y separalos con comas (,):");
            String ColorUser = Console.ReadLine();
            //Un string Se puede convertitr en arrglo con su propiedad Splut, dandole un padron. si no tiene un patron pues no jala
            String[] newColor = ColorUser.Split(',');
            Console.WriteLine(newColor);
        }
        public void multidimencional()
        {
            int[,] array = new int[4, 2];
            Console.WriteLine(array);
        }

        static void Main(String[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("arreglo sencillo");
                String[] sencillo = { "rojo", "Blanco", "morado" };
                Console.WriteLine("[(0)]", string.Join(",", sencillo));
                Console.WriteLine("Arreglo Dos Dimenciones");
                int[,] dosDienciones = new int[5, 5];
                for (int i = 0; i < dosDienciones.GetLength(0); i++) //se usa indicadores para comparar dato por dato
                {
                    for (int j = 0; j < dosDienciones.GetLength(1); j++)
                    {
                        Console.WriteLine("{0}, {1} = {2}", i, j, dosDienciones[i, j]);
                    }
                }

                Console.WriteLine("Aregllo 3 Dimenciones");
                int[,,] tresDimenciones = new int[5, 5, 5];
                for (int i = 0; i < tresDimenciones.GetLength(0); i++) //se usa indicadores para comparar dato por dato
                {
                    for (int j = 0; j < tresDimenciones.GetLength(1); j++)
                    {
                        for (int k = 0; k < tresDimenciones.GetLength(2); k++)
                        {
                            tresDimenciones[i, j, k] = i + j + k;
                            Console.WriteLine("{0},{1},{2} = {3}", i, j, k, tresDimenciones[i, j, k]);
                        }
                    }
                }

                //Console.WriteLine("[(0)]", string.Join(",", tresDimenciones));
                //string exit = Console.ReadLine();

                //Console.WriteLine("([0])", string.Join(",", Colores));

            }
        }
        class MemoriaData
        {
            internal readonly object resultado;
            public DateTime fecha;
            public string operacion;
            public int Resultado;

            public MemoriaData(string date, string operacion, float resultado)
            {
                fecha = DateTime.Parse(date);
                operacion = operacion;
                resultado = resultado;

            }
        }



    }
}
