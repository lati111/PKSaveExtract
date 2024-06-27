using PKHeX.Core;
using PKSaveExtract.Enums;

namespace PKSaveExtract.Models
{
    internal class Gen6Pokemon : AbstractPokemon
    {
        private PK6? pkmn;

        public Gen6Pokemon(PKM pokemon) : base(pokemon)
        {
        }

        protected override void Init()
        {
            pkmn = (PK6)pokemon;
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
            if (pkmn.RibbonChampionG3 == true || pkmn.RibbonChampionG6Hoenn)
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
            if (pkmn.RibbonChampionSinnoh == true)
            {
                ribbons.Add(Ribbons.ChampionSinnohRibbon);
            }
            if (pkmn.RibbonChampionKalos == true)
            {
                ribbons.Add(Ribbons.ChampionKalosRibbon);
            }
            if (pkmn.RibbonChampionWorld == true)
            {
                ribbons.Add(Ribbons.WorldChampionRibbon);
            }
            if (pkmn.HasBattleMemoryRibbon == true)
            {
                ribbons.Add(Ribbons.BattleMemoryRibbon);
            }

            //contest ribbons
            if (pkmn.HasContestMemoryRibbon == true)
            {
                ribbons.Add(Ribbons.ContestMemoryRibbon);
            }
            if (pkmn.RibbonContestStar == true)
            {
                ribbons.Add(Ribbons.ContestStarRibbon);
            }
            if (pkmn.RibbonMasterBeauty == true)
            {
                ribbons.Add(Ribbons.BeautyMasterRibbon);
            }
            if (pkmn.RibbonMasterCleverness == true)
            {
                ribbons.Add(Ribbons.ClevernessMasterRibbon);
            }
            if (pkmn.RibbonMasterCoolness == true)
            {
                ribbons.Add(Ribbons.CoolnessMasterRibbon);
            }
            if (pkmn.RibbonMasterCuteness == true)
            {
                ribbons.Add(Ribbons.CutenessMasterRibbon);
            }
            if (pkmn.RibbonMasterToughness == true)
            {
                ribbons.Add(Ribbons.ToughnessMasterRibbon);
            }

            //battle maison.tree ribbons
            if (pkmn.RibbonBattlerExpert == true)
            {
                ribbons.Add(Ribbons.ExpertBattlerRibbon);
            }
            if (pkmn.RibbonBattlerSkillful == true)
            {
                ribbons.Add(Ribbons.SkillfullBattlerRibbon);
            }

            //memorial ribbons
            if (pkmn.RibbonAlert == true)
            {
                ribbons.Add(Ribbons.AlertRibbon);
            }
            if (pkmn.RibbonArtist == true)
            {
                ribbons.Add(Ribbons.ArtistRibbon);
            }
            if (pkmn.RibbonBirthday == true)
            {
                ribbons.Add(Ribbons.BirthdayRibbon);
            }
            if (pkmn.RibbonCareless == true)
            {
                ribbons.Add(Ribbons.CarelessRibbon);
            }
            if (pkmn.RibbonGorgeous == true)
            {
                ribbons.Add(Ribbons.GorgeousRibbon);
            }
            if (pkmn.RibbonGorgeousRoyal == true)
            {
                ribbons.Add(Ribbons.GorgeousRoyalRibbon);
            }
            if (pkmn.RibbonLegend == true)
            {
                ribbons.Add(Ribbons.LegendRibbon);
            }
            if (pkmn.RibbonNational == true)
            {
                ribbons.Add(Ribbons.NationalRibbon);
            }
            if (pkmn.RibbonPremier == true)
            {
                ribbons.Add(Ribbons.PremierRibbon);
            }
            if (pkmn.RibbonRecord == true)
            {
                ribbons.Add(Ribbons.RecordRibbon);
            }
            if (pkmn.RibbonRelax == true)
            {
                ribbons.Add(Ribbons.RelaxRibbon);
            }
            if (pkmn.RibbonRoyal == true)
            {
                ribbons.Add(Ribbons.RoyalRibbon);
            }
            if (pkmn.RibbonShock == true)
            {
                ribbons.Add(Ribbons.ShockRibbon);
            }
            if (pkmn.RibbonSmile == true)
            {
                ribbons.Add(Ribbons.SmileRibbon);
            }
            if (pkmn.RibbonSnooze == true)
            {
                ribbons.Add(Ribbons.SnoozeRibbon);
            }


            //gift ribbons
            if (pkmn.RibbonClassic == true)
            {
                ribbons.Add(Ribbons.ClassicRibbon);
            }
            if (pkmn.RibbonCountry == true)
            {
                ribbons.Add(Ribbons.CountryRibbon);
            }
            if (pkmn.RibbonDowncast == true)
            {
                ribbons.Add(Ribbons.DowncastRibbon);
            }
            if (pkmn.RibbonEarth == true)
            {
                ribbons.Add(Ribbons.EarthRibbon);
            }
            if (pkmn.RibbonEffort == true)
            {
                ribbons.Add(Ribbons.EffortRibbon);
            }
            if (pkmn.RibbonEvent == true)
            {
                ribbons.Add(Ribbons.EventRibbon);
            }
            if (pkmn.RibbonFootprint == true)
            {
                ribbons.Add(Ribbons.FootprintRibbon);
            }
            if (pkmn.RibbonSouvenir == true)
            {
                ribbons.Add(Ribbons.SouvenirRibbon);
            }
            if (pkmn.RibbonSpecial == true)
            {
                ribbons.Add(Ribbons.SpecialRibbon);
            }
            if (pkmn.RibbonWishing == true)
            {
                ribbons.Add(Ribbons.WishingRibbon);
            }
            if (pkmn.RibbonWorld == true)
            {
                ribbons.Add(Ribbons.WorldRibbon);
            }

            return ribbons;
        }
    }
}
