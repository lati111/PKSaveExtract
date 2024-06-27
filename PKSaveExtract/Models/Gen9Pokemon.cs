using PKHeX.Core;
using PKSaveExtract.Enums;

namespace PKSaveExtract.Models
{
    internal class Gen9Pokemon : AbstractPokemon
    {
        private PK9? pkmn;

        public Gen9Pokemon(PKM pokemon) : base(pokemon)
        {
        }

        protected override void Init()
        {
            pkmn = (PK9)pokemon;
            tera_type = FormatText(pkmn.TeraType.ToString());
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
