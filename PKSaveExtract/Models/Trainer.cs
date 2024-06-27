﻿using PKHeX.Core;

namespace PKSaveExtract.Models
{
    internal class Trainer
    {
        public int SID;
        public int TID;
        public string name;
        public string gender;
        public string game;

        public Trainer(PKM pokemon, string game)
        {
            SID = pokemon.SID16;
            TID = pokemon.TID16;
            name = pokemon.OriginalTrainerName;
            gender = (pokemon.OriginalTrainerGender == 0) ? "M" : "F";
            this.game = game;
        }
    }
}
