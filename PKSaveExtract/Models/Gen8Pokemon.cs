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
            if (pkmn.RibbonChampionAlola == true)
            {
                ribbons.Add(Ribbons.ChampionAlolaRibbon);
            }
            if (pkmn.RibbonChampionGalar == true)
            {
                ribbons.Add(Ribbons.ChamptionGalarRibbon);
            }
            if (pkmn.RibbonChampionWorld == true)
            {
                ribbons.Add(Ribbons.WorldChampionRibbon);
            }
            if (pkmn.HasBattleMemoryRibbon == true)
            {
                ribbons.Add(Ribbons.BattleMemoryRibbon);
            }

            //battle areas ribbons
            if (pkmn.RibbonBattlerExpert == true)
            {
                ribbons.Add(Ribbons.ExpertBattlerRibbon);
            }
            if (pkmn.RibbonBattlerSkillful == true)
            {
                ribbons.Add(Ribbons.SkillfullBattlerRibbon);
            }
            if (pkmn.RibbonBattleTreeGreat == true)
            {
                ribbons.Add(Ribbons.BattleTreeGreatRibbon);
            }
            if (pkmn.RibbonBattleTreeMaster == true)
            {
                ribbons.Add(Ribbons.BattleTreeMasterRibbon);
            }
            if (pkmn.RibbonTowerMaster == true)
            {
                ribbons.Add(Ribbons.TowerMasterRibbon);
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
            if (pkmn.RibbonTwinklingStar == true)
            {
                ribbons.Add(Ribbons.TwiklingStarRibbon);
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
            if (pkmn.RibbonBestFriends == true)
            {
                ribbons.Add(Ribbons.BestFriendsRibbon);
            }
            if (pkmn.RibbonTraining == true)
            {
                ribbons.Add(Ribbons.TrainingRibbon);
            }
            if (pkmn.RibbonBattleRoyale == true)
            {
                ribbons.Add(Ribbons.BattleRoyaleRibbon);
            }
            if (pkmn.RibbonTowerMaster == true)
            {
                ribbons.Add(Ribbons.MasterRankRibbon);
            }
            if (pkmn.RibbonHisui == true)
            {
                ribbons.Add(Ribbons.HisuiRibbon);
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
