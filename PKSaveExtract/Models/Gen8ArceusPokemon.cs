using PKHeX.Core;
using PKSaveExtract.Enums;
using System.Diagnostics;

namespace PKSaveExtract.Models
{
    internal class Gen8ArceusPokemon : AbstractPokemon
    {
        private PA8? pkmn;

        public Gen8ArceusPokemon(PKM pokemon) : base(pokemon)
        {
        }


        protected override void Init()
        {
            pkmn = (PA8)pokemon;
            dynamax_level = pkmn.DynamaxLevel;
            if (pkmn.CanGigantamax == true)
            {
                can_gigantamiax = true;
            }

            if (pkmn.IsAlpha == true)
            {
                is_alpha = true;
            }
        }

        protected override string GetLocation(int locationID)
        {
            string location = GameInfo.GetLocationName(false, (ushort)locationID, 0, pokemon.Generation, GameVersion.PLA);
            return FormatText(location);
        }

        protected override int ExtractBeauty()
        {
            if (pkmn == null) { return 0; }
            return pkmn.ContestBeauty;
        }

        protected override int ExtractCool()
        {
            if (pkmn == null) { return 0; }
            return pkmn.ContestCool;
        }

        protected override int ExtractCute()
        {
            if (pkmn == null) { return 0; }
            return pkmn.ContestCute;
        }

        protected override int ExtractSheen()
        {
            if (pkmn == null) { return 0; }
            return pkmn.ContestSheen;
        }

        protected override int ExtractSmart()
        {
            if (pkmn == null) { return 0; }
            return pkmn.ContestSmart;
        }

        protected override int ExtractTough()
        {
            if (pkmn == null) { return 0; }
            return pkmn.ContestTough;
        }
    }
}
