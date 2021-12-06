using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamingSiteProject.data
{
    public class Bruger
    {
        private String navn;
        private String kodeord;

        public Bruger()
        {
        }

        public Bruger(string navn, string kodeord)
        {
            this.navn = navn;
            this.kodeord = kodeord;
        }

        public string Navn
        {
            get => navn;
            set => this.navn = value;
        }

        public string Kodeord
        {
            get => kodeord;
            set => this.kodeord = value;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Kodeord)}: {Kodeord}";
        }
    }
}
