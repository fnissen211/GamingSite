using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GamingSiteProject.data;
using GamingSiteProject.services;
using System.Text.Json.Serialization;

namespace GamingSiteProject.services
{
    public class BrugerListe:IBrugerListe
    {

        private string _filename = @"data\Users.json";
        public List<Bruger> Bruger { get; private set; }

        public LoggedInUser _loggedInUser;

        public BrugerListe(LoggedInUser loggedinuser)
        {
            _loggedInUser = loggedinuser;

            using (var file = File.OpenText(_filename))
            {
                Bruger = JsonSerializer.Deserialize<List<Bruger>>(file.ReadToEnd());
            }
        }


        public void AddBruger(Bruger bruger)
        {
            Bruger.Add(bruger);
            
            SaveToJson();
        }

        public void AddGame(string navn, List<string> gameList)
        {

            foreach (var item in Bruger)
            {

                if (item.Navn == navn)
                {
                    item.GamesList.AddRange(gameList);
                    SaveToJson();
                }

            }


        }

        public void UpdateGameList(LoggedInUser loggedInuser)
        {
            var updateList = loggedInuser.GamesList;

            updateList.Add(_loggedInUser.GamesList.ToString());
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

        public override string ToString()
        {
            return $"{nameof(Bruger)}: {Bruger}, {nameof(_loggedInUser.GamesList)}: {_loggedInUser.GamesList}";
        }

    }
}
