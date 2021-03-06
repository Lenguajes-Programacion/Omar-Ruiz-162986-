﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticaDos
{
    class Memoria
    {
        public List<MemoriaData> db = new List<MemoriaData>();
        public Memoria()
        {
            db = new List<MemoriaData>();
        }
       
        public void LeerMemoria()
        {
            ConsoleColor currentColor = Console.BackgroundColor;
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            int i = 0;

            foreach (var item in dbObject)
            {

                MemoriaData memoriaData = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(), item.Value["resultado"].ToString());
                this.db.Add(memoriaData);
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.Resultado.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }

        public int GetMemoriaData(String key)
        {
     
            int index = int.Parse(key);
            MemoriaData data = db[index];
            return data.Resultado;
        }

        public void GuardarMemoria (MemoriaData data)
        {
            db.Add(data);
            int i = 0;
            db.ForEach((MemoriaData memoriaData) =>
            {
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.Resultado.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            });
            string json = JsonConvert.SerializeObject(db.ToArray(), Formatting.Indented);
            string archivoDB = "../../../db.json";
            File.WriteAllText(archivoDB, json);
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

        public void Arreglos ()
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

                string exit = Console.ReadLine();
                if(exit == "y")
                {
                    salir = true;
                }
                //Console.WriteLine("([0])", string.Join(",", Colores));

            }
        }
       public class MemoriaData
        {

            public DateTime fecha;
            public string operacion;
            public int Resultado;

            public MemoriaData(String date, string operacion, String result)
            {
                fecha = DateTime.Parse(date);
                Resultado = int.Parse(result);
                //operacion = operation;

            }
        }

        


    }
}
