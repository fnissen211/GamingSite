using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GamingSiteProject.data;

namespace GamingSiteProject.services
{
    public class BrugerListeJson:IBrugerListe
    {

        private string _filename = @"data\Users.json";
        public List<Bruger> Bruger { get; private set; }

        public BrugerListeJson()
        {
            using(var file = File.OpenText(_filename))
            {
                Bruger = JsonSerializer.Deserialize<List<Bruger>>(file.ReadToEnd());
            }
        }


        public void AddBruger(Bruger bruger)
        {
            Bruger.Add(bruger);
            SaveToJson();
        }

        private void SaveToJson()
        {
            using (var file  = File.OpenWrite(_filename))
            {
                var writer = new Utf8JsonWriter(file, new JsonWriterOptions());
                JsonSerializer.Serialize(writer, Bruger);
            }
        }
    }
}
