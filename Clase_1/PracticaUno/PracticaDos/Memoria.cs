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
            var result = dbObject.ToString();
            Console.WriteLine(result);
        }
    }
}
