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
            foreach ( var item in dbObject)
            {
                Console.WriteLine("dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(item.Key, item.Value["operacion"].ToString(), (float)item.Value["resultado"]);
                Console.WriteLine("{0 - {1}", memoriaData.fecha.ToLongDateString());
                Console.WriteLine(memoriaData.fecha.ToLongDateString());
                Console.WriteLine(memoriaData.resultado.ToString());
                Console.WriteLine("\n");
            }
        }
    }
    class MemoriaData
    {
        public DateTime fecha;
        public string operacion;
        public int resultado;

        public MemoriaData (string date DateTime fecha, string operacion, int resultado)
        {
            fecha = DateTime.Parse(date);
            operacion = operacion;
            resultado = resultado;

        }
    }




}
