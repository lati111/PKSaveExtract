using PKHeX.Core;
using PKSaveExtract.Enums;

namespace PKSaveExtract.Models
{
    internal class Gen3Pokemon : AbstractPokemon
    {
        private PK3? pkmn;

        public Gen3Pokemon(PKM pokemon) : base(pokemon)
        {
        }

        protected override void Init()
        {
            pkmn = (PK3)pokemon;
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

        protected override List<string> ExtractRibbons()
        {
            List<string> ribbons = new();
            if (pkmn == null) { return ribbons; }

            //champion ribbons
            if (pkmn.RibbonChampionBattle == true)
            {
                ribbons.Add(Ribbons.ChampionBattleRibbon);
            }
            if (pkmn.RibbonChampionG3 == true)
            {
                ribbons.Add(Ribbons.ChampionHoennRibbon);
            }
            if (pkmn.RibbonChampionNational == true)
            {
                ribbons.Add(Ribbons.NationalChampionRibbon);
            }
            if (pkmn.RibbonChampionRegional == true)
            {
                ribbons.Add(Ribbons.RegionalChampionRibbon);
            }

            //contest ribbons
            if (pkmn.RibbonCountG3Beauty > 0)
            {
                ribbons.Add(Ribbons.HoennBeautyRibbon);
            }
            if (pkmn.RibbonCountG3Beauty > 1)
            {
                ribbons.Add(Ribbons.HoennBeautySuperRibbon);
            }
            if (pkmn.RibbonCountG3Beauty > 2)
            {
                ribbons.Add(Ribbons.HoennBeautyHyperRibbon);
            }
            if (pkmn.RibbonCountG3Beauty > 3)
            {
                ribbons.Add(Ribbons.HoennBeautyMasterRibbon);
            }
            if (pkmn.RibbonCountG3Cool > 0)
            {
                ribbons.Add(Ribbons.HoennCoolRibbon);
            }
            if (pkmn.RibbonCountG3Cool > 1)
            {
                ribbons.Add(Ribbons.HoennCoolSuperRibbon);
            }
            if (pkmn.RibbonCountG3Cool > 2)
            {
                ribbons.Add(Ribbons.HoennCoolHyperRibbon);
            }
            if (pkmn.RibbonCountG3Cool > 3)
            {
                ribbons.Add(Ribbons.HoennCoolMasterRibbon);
            }
            if (pkmn.RibbonCountG3Cute > 0)
            {
                ribbons.Add(Ribbons.HoennCuteRibbon);
            }
            if (pkmn.RibbonCountG3Cute > 1)
            {
                ribbons.Add(Ribbons.HoennCuteSuperRibbon);
            }
            if (pkmn.RibbonCountG3Cute > 2)
            {
                ribbons.Add(Ribbons.HoennCuteHyperRibbon);
            }
            if (pkmn.RibbonCountG3Cute > 3)
            {
                ribbons.Add(Ribbons.HoennCuteMasterRibbon);
            }
            if (pkmn.RibbonCountG3Smart > 0)
            {
                ribbons.Add(Ribbons.HoennSmartRibbon);
            }
            if (pkmn.RibbonCountG3Smart > 1)
            {
                ribbons.Add(Ribbons.HoennSmartSuperRibbon);
            }
            if (pkmn.RibbonCountG3Smart > 2)
            {
                ribbons.Add(Ribbons.HoennSmartHyperRibbon);
            }
            if (pkmn.RibbonCountG3Smart > 3)
            {
                ribbons.Add(Ribbons.HoennSmartMasterRibbon);
            }
            if (pkmn.RibbonCountG3Tough > 0)
            {
                ribbons.Add(Ribbons.HoennToughRibbon);
            }
            if (pkmn.RibbonCountG3Tough > 1)
            {
                ribbons.Add(Ribbons.HoennToughSuperRibbon);
            }
            if (pkmn.RibbonCountG3Tough > 2)
            {
                ribbons.Add(Ribbons.HoennToughHyperRibbon);
            }
            if (pkmn.RibbonCountG3Tough > 3)
            {
                ribbons.Add(Ribbons.HoennToughMasterRibbon);
            }

            //memorial and gift ribbons
            if (pkmn.RibbonArtist == true)
            {
                ribbons.Add(Ribbons.ArtistRibbon);
            }
            if (pkmn.RibbonCountry == true)
            {
                ribbons.Add(Ribbons.CountryRibbon);
            }
            if (pkmn.RibbonEarth == true)
            {
                ribbons.Add(Ribbons.EarthRibbon);
            }
            if (pkmn.RibbonEffort == true)
            {
                ribbons.Add(Ribbons.EffortRibbon);
            }
            if (pkmn.RibbonNational == true)
            {
                ribbons.Add(Ribbons.NationalRibbon);
            }
            if (pkmn.RibbonWorld == true)
            {
                ribbons.Add(Ribbons.WorldRibbon);
            }

            return ribbons;
        }
    }
}
