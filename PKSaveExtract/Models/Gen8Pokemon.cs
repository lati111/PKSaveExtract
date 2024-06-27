using PKHeX.Core;
using PKSaveExtract.Enums;

namespace PKSaveExtract.Models
{
    internal class Gen8Pokemon : AbstractPokemon
    {
        private PK8? pkmn;

        public Gen8Pokemon(PKM pokemon) : base(pokemon)
        {
        }

        protected override void Init()
        {
            this.pkmn = (PK8)pokemon;
            dynamax_level = pkmn.DynamaxLevel;
            if (pkmn.CanGigantamax == true)
            {
                can_gigantamiax = true;
            }
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
