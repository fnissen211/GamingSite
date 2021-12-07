using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.data;

namespace GamingSiteProject.services
{
    public class BrugerListe : IBrugerListe
    {
        private List<Bruger> _bruger = null;

        public BrugerListe()
        {
            if (_bruger == null)
            {
                _bruger = new List<Bruger>();
                _bruger.Add(new Bruger(0,"Mads", "1234", BrugerType.Administrator));
                _bruger.Add(new Bruger(1,"Frede", "1234", BrugerType.Administrator));
                _bruger.Add(new Bruger(2,"Peter", "1234", BrugerType.Bruger));
                _bruger.Add(new Bruger(3,"Jakob", "1234", BrugerType.Bruger));

            }
        }

        public List<Bruger> Bruger
        {
            get => _bruger;
           
        }

        public void AddBruger(Bruger bruger)
        {
            _bruger.Add(bruger);
        }
    }
}
