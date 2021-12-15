﻿using System.Collections.Generic;
using GamingSiteProject.data;

namespace GamingSiteProject.services
{
    public interface IBrugerListe
    {
        List<Bruger> Bruger { get; }
        void AddBruger(Bruger bruger);
        bool CheckBruger(Bruger bruger);
        void AddGame(Bruger bruger);
        void UpdateGameList(Bruger bruger);
    }
}