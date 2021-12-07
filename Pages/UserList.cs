using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GamingSiteProject.data;

namespace GamingSiteProject.Pages
{
    public class UserList
    {
        private string _file = @"data\Users.json";

        public List<Bruger> BrugerListe { get; private set; }

        public UserList()
        {
            using (var file = File.OpenText(_file))
            {
                BrugerListe = JsonSerializer.Deserialize<List<Bruger>>(file.ReadToEnd());
            }
            
        }

        public void Add(Bruger bruger)
        {
            BrugerListe.Add(bruger);
            StoreToJson();
        }

        public void UpdateUser(Bruger bruger)
        {

        }


        public void StoreToJson()
        {
            using (var file = File.OpenWrite(_file))
            {
                var writer = new Utf8JsonWriter(file, new JsonWriterOptions());
                JsonSerializer.Serialize(writer, BrugerListe);
            }
        }
    }
}
