using PKHeX.Core;
using PKSaveExtract.Enums;

namespace PKSaveExtract.Models
{
    internal class Gen5Pokemon : AbstractPokemon
    {
        private PK5? pkmn;

        public Gen5Pokemon(PKM pokemon) : base(pokemon)
        {
        }

        protected override void Init()
        {
            pkmn = (PK5)pokemon;
            if (pkmn.NSparkle == true) 
            {
                has_n_sparkle = true;
            }
        }

        protected override int ExtractBeauty()
        {
            if (pkmn == null) { return 0; }
            return pkmn.CNT_Beauty;
        }

        protected override int ExtractCool()
        {
            if (pkmn == null) { return 0; }
            return pkmn.CNT_Cool;
        }

        protected override int ExtractCute()
        {
            if (pkmn == null) { return 0; }
            return pkmn.CNT_Cute;
        }

        protected override int ExtractSheen()
        {
            if (pkmn == null) { return 0; }
            return pkmn.CNT_Sheen;
        }

        protected override int ExtractSmart()
        {
            if (pkmn == null) { return 0; }
            return pkmn.CNT_Smart;
        }

        protected override int ExtractTough()
        {
            if (pkmn == null) { return 0; }
            return pkmn.CNT_Tough;
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
            if (pkmn.RibbonChampionSinnoh == true)
            {
                ribbons.Add(Ribbons.ChampionSinnohRibbon);
            }
            if (pkmn.RibbonChampionWorld == true)
            {
                ribbons.Add(Ribbons.WorldChampionRibbon);
            }

            //battle tower ribbons
            if (pkmn.RibbonAbility == true)
            {
                ribbons.Add(Ribbons.AbilityRibbon);
            }
            if (pkmn.RibbonAbilityDouble == true)
            {
                ribbons.Add(Ribbons.DoubleAbilityRibbon);
            }
            if (pkmn.RibbonAbilityGreat == true)
            {
                ribbons.Add(Ribbons.GreatAbilityRibbon);
            }
            if (pkmn.RibbonAbilityMulti == true)
            {
                ribbons.Add(Ribbons.MultiAbilityRibbon);
            }
            if (pkmn.RibbonAbilityPair == true)
            {
                ribbons.Add(Ribbons.PairAbilityRibbon);
            }
            if (pkmn.RibbonAbilityWorld == true)
            {
                ribbons.Add(Ribbons.WorldAbilityRibbon);
            }

            //hoenn contest ribbons
            if (pkmn.RibbonG3Beauty == true)
            {
                ribbons.Add(Ribbons.HoennBeautyRibbon);
            }
            if (pkmn.RibbonG3BeautySuper == true)
            {
                ribbons.Add(Ribbons.HoennBeautySuperRibbon);
            }
            if (pkmn.RibbonG3BeautyHyper == true)
            {
                ribbons.Add(Ribbons.HoennBeautyHyperRibbon);
            }
            if (pkmn.RibbonG3BeautyMaster == true)
            {
                ribbons.Add(Ribbons.HoennBeautyMasterRibbon);
            }
            if (pkmn.RibbonG3Cool == true)
            {
                ribbons.Add(Ribbons.HoennCoolRibbon);
            }
            if (pkmn.RibbonG3CoolSuper == true)
            {
                ribbons.Add(Ribbons.HoennCoolSuperRibbon);
            }
            if (pkmn.RibbonG3CoolHyper == true)
            {
                ribbons.Add(Ribbons.HoennCoolHyperRibbon);
            }
            if (pkmn.RibbonG3CoolMaster == true)
            {
                ribbons.Add(Ribbons.HoennCoolMasterRibbon);
            }
            if (pkmn.RibbonG3Cute == true)
            {
                ribbons.Add(Ribbons.HoennCuteRibbon);
            }
            if (pkmn.RibbonG3CuteSuper == true)
            {
                ribbons.Add(Ribbons.HoennCuteSuperRibbon);
            }
            if (pkmn.RibbonG3CuteHyper == true)
            {
                ribbons.Add(Ribbons.HoennCuteHyperRibbon);
            }
            if (pkmn.RibbonG3CuteMaster == true)
            {
                ribbons.Add(Ribbons.HoennCuteMasterRibbon);
            }
            if (pkmn.RibbonG3Smart == true)
            {
                ribbons.Add(Ribbons.HoennSmartRibbon);
            }
            if (pkmn.RibbonG3SmartSuper == true)
            {
                ribbons.Add(Ribbons.HoennSmartSuperRibbon);
            }
            if (pkmn.RibbonG3SmartHyper == true)
            {
                ribbons.Add(Ribbons.HoennSmartHyperRibbon);
            }
            if (pkmn.RibbonG3SmartMaster == true)
            {
                ribbons.Add(Ribbons.HoennSmartMasterRibbon);
            }
            if (pkmn.RibbonG3Tough == true)
            {
                ribbons.Add(Ribbons.HoennToughRibbon);
            }
            if (pkmn.RibbonG3ToughSuper == true)
            {
                ribbons.Add(Ribbons.HoennToughSuperRibbon);
            }
            if (pkmn.RibbonG3ToughHyper == true)
            {
                ribbons.Add(Ribbons.HoennToughHyperRibbon);
            }
            if (pkmn.RibbonG3ToughMaster == true)
            {
                ribbons.Add(Ribbons.HoennToughMasterRibbon);
            }

            //sinnoh contest ribbons
            if (pkmn.RibbonG4Beauty == true)
            {
                ribbons.Add(Ribbons.SinnohBeautyRibbon);
            }
            if (pkmn.RibbonG4BeautyGreat == true)
            {
                ribbons.Add(Ribbons.SinnohBeautyGreatRibbon);
            }
            if (pkmn.RibbonG4BeautyUltra == true)
            {
                ribbons.Add(Ribbons.SinnohBeautyUltraRibbon);
            }
            if (pkmn.RibbonG4BeautyMaster == true)
            {
                ribbons.Add(Ribbons.SinnohBeautyMasterRibbon);
            }
            if (pkmn.RibbonG4Cool == true)
            {
                ribbons.Add(Ribbons.SinnohCoolRibbon);
            }
            if (pkmn.RibbonG4CoolGreat == true)
            {
                ribbons.Add(Ribbons.SinnohCoolGreatRibbon);
            }
            if (pkmn.RibbonG4CoolUltra == true)
            {
                ribbons.Add(Ribbons.SinnohCoolUltraRibbon);
            }
            if (pkmn.RibbonG4CoolMaster == true)
            {
                ribbons.Add(Ribbons.SinnohCoolMasterRibbon);
            }
            if (pkmn.RibbonG4Cute == true)
            {
                ribbons.Add(Ribbons.SinnohCuteRibbon);
            }
            if (pkmn.RibbonG4CuteGreat == true)
            {
                ribbons.Add(Ribbons.SinnohCuteGreatRibbon);
            }
            if (pkmn.RibbonG4CuteUltra == true)
            {
                ribbons.Add(Ribbons.SinnohCuteUltraRibbon);
            }
            if (pkmn.RibbonG4CuteMaster == true)
            {
                ribbons.Add(Ribbons.SinnohCuteMasterRibbon);
            }
            if (pkmn.RibbonG4Smart == true)
            {
                ribbons.Add(Ribbons.SinnohSmartRibbon);
            }
            if (pkmn.RibbonG4SmartGreat == true)
            {
                ribbons.Add(Ribbons.SinnohSmartGreatRibbon);
            }
            if (pkmn.RibbonG4SmartUltra == true)
            {
                ribbons.Add(Ribbons.SinnohSmartUltraRibbon);
            }
            if (pkmn.RibbonG4SmartMaster == true)
            {
                ribbons.Add(Ribbons.SinnohSmartMasterRibbon);
            }
            if (pkmn.RibbonG4Tough == true)
            {
                ribbons.Add(Ribbons.SinnohToughRibbon);
            }
            if (pkmn.RibbonG4ToughGreat == true)
            {
                ribbons.Add(Ribbons.SinnohToughGreatRibbon);
            }
            if (pkmn.RibbonG4ToughUltra == true)
            {
                ribbons.Add(Ribbons.SinnohToughUltraRibbon);
            }
            if (pkmn.RibbonG4ToughMaster == true)
            {
                ribbons.Add(Ribbons.SinnohToughMasterRibbon);
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
