using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GamingSiteProject.data;
using System.Text.Json.Serialization;

namespace GamingSiteProject.services
{
    public class BrugerListe:IBrugerListe
    {

        private string _filename = @"data\Users.json";
        public List<Bruger> Bruger { get; private set; }

        public BrugerListe()
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

        public void AddGame(Bruger bruger)
        {
            Bruger.Add(bruger);
        }

        private void SaveToJson()
        {
            using (var file  = File.OpenWrite(_filename))
            {
                var writer = new Utf8JsonWriter(file, new JsonWriterOptions());
                JsonSerializer.Serialize(writer, Bruger);
            }
        }

        public bool CheckBruger(Bruger bruger)
        {
            if (bruger == null)
            {
                return false;
            }

            foreach (var xx in Bruger)
            {
                if (xx.Navn == bruger.Navn &&
                    xx.Kodeord == bruger.Kodeord)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
