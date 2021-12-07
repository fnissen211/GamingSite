using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using GamingSiteProject.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace GamingSiteProject.data
{
    public class Bruger:UserList
    {
        public string _navn { get; set; }
        public string _kodeord { get; set; }


        

        
        public Bruger(string navn, string kodeord)
        {
            this._navn = navn;
            this._kodeord = kodeord;

        }

        public Bruger()
        {
            
        }


        public string Navn
        {
            get => _navn;
            set => this._navn = value;
        }


        public string Kodeord
        {
            get => _kodeord;
            set => this._kodeord = value;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Kodeord)}: {Kodeord}";
        }
    }
}
