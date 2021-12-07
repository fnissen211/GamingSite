using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using GamingSiteProject.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace GamingSiteProject.data
{
    public enum BrugerType
    {
        Bruger,
        Administrator
    }

    public class Bruger
    {
        public string ProfilePicture { get; set; }

        private int _id;
        private string _navn;
        private string _kodeord;
        private BrugerType _type;



        public Bruger()
        {

        }

        public Bruger(int id, string navn, string kodeord, BrugerType type)
        {
            _id = id;
            _navn = navn;
            _kodeord = kodeord;
            _type = type;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [Required(ErrorMessage = "Husk at vælge et navn.")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Dit navn skal være mellem 4 og 12 tegn.")]
        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        [Required(ErrorMessage = "Husk at vælge et kodeord.")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Din kode skal være mellem 6 og 16 tegn.")]
        public string Kodeord
        {
            get => _kodeord;
            set => _kodeord = value;
        }

        public BrugerType Type
        {
            get => _type;
            set => _type = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Kodeord)}: {Kodeord}, {nameof(Type)}: {Type}";
        }
    }
}
