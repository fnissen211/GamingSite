using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.data;
using GamingSiteProject.services;

namespace GamingSiteProject.services
{
    public class LoggedInUser
    {

        public bool LoggedIn { get; set; }

        public string Navn { get; set; }

        

        public List<Bruger> BrugerSpilleListe { get; set; }

        
    }
}
