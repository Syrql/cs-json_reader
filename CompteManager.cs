using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class CompteManager
    {
        public void save(Object o)
        {
            string pathFile = @"PATH_HERE" + o.ToString() + ".json";

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(o, options);

            File.WriteAllText(pathFile, json);
            Console.WriteLine("Fichier enregistré!");
        }

        public void read(List<CompteBancaire> comptes)
        {
            string[] files = Directory.GetFiles(@"PATH_HERE");

            if (files.Length == 0) return;

            foreach (string file in files)
            {

                string jsonString = File.ReadAllText(file);
                CompteBancaire compte = JsonSerializer.Deserialize<CompteBancaire>(jsonString)!;

                if (compte == null) return;

                comptes.Add(compte);
            }
        }
    }
}
