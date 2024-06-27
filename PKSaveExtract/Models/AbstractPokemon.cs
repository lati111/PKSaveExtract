using PKHeX.Core;
using PKSaveExtract.Enums;
using System.Diagnostics;

namespace PKSaveExtract.Models
{
    internal abstract class AbstractPokemon
    {
        protected PKM pokemon;

        public uint PID;
        public string? nickname;
        public bool is_shiny = false;

        public string nature;
        public string gender = "";
        public string species;
        public string ball = "poke_ball";
        public int characteristic;
        public int friendship;

        public int height;
        public int weight;

        public int level = 1;
        public int form = 0;
        public string ability;
        public int HP_power;
        public string HP_type;

        public int beauty;
        public int cool;
        public int cute;
        public int sheen;
        public int smart;
        public int tough;

        public int HP_IV;
        public int ATK_IV;
        public int DEF_IV;
        public int SPA_IV;
        public int SPD_IV;
        public int SPE_IV;

        public int HP_EV;
        public int ATK_EV;
        public int DEF_EV;
        public int SPA_EV;
        public int SPD_EV;
        public int SPE_EV;

        public string? move1;
        public int? move1_pp_ups;
        public string? move2;
        public int? move2_pp_ups;
        public string? move3;
        public int? move3_pp_ups;
        public string? move4;
        public int? move4_pp_ups;

        public bool was_egg = false;
        public string met_date;
        public string met_location;
        public string met_game;
        public int met_level;
        public Trainer trainer;

        public string tera_type;
        public bool is_alpha = false;
        public bool has_n_sparkle = false;
        public bool can_gigantamiax = false;
        public int dynamax_level = 0;

        public List<string> ribbons = new();

        protected AbstractPokemon(PKM pokemon)
        {
            this.pokemon = pokemon;

            Debug.WriteLine(pokemon.PID.ToString());
            PID = pokemon.PID;
            nickname = pokemon.Nickname;
            is_shiny = pokemon.IsShiny;
            tera_type = GetType(pokemon.PersonalInfo.Type1);
            Init();

            form = pokemon.Form;
            level = pokemon.CurrentLevel;
            friendship = pokemon.CurrentFriendship;

            species = ExtractSpecies();
            nature = ExtractNature();
            gender = ExtractGender();
            ball = ExtractBall();

            height = pokemon.PersonalInfo.Height;
            weight = pokemon.PersonalInfo.Weight;

            ability = ExtractAbility();
            HP_power = pokemon.HPPower;
            HP_type = GetType(pokemon.HPType);

            beauty = ExtractBeauty();
            cool = ExtractCool();
            cute = ExtractCute();
            sheen = ExtractSheen();
            smart = ExtractSmart();
            tough = ExtractTough();

            HP_EV = pokemon.EV_HP;
            ATK_EV = pokemon.EV_ATK;
            DEF_EV = pokemon.EV_DEF;
            SPA_EV = pokemon.EV_SPA;
            SPD_EV = pokemon.EV_SPD;
            SPE_EV = pokemon.EV_SPE;

            HP_IV = pokemon.IV_HP;
            ATK_IV = pokemon.IV_ATK;
            DEF_IV = pokemon.IV_DEF;
            SPA_IV = pokemon.IV_SPA;
            SPD_IV = pokemon.IV_SPD;
            SPE_IV = pokemon.IV_SPE;

            move1 = GetMove(pokemon.Move1);
            move2 = GetMove(pokemon.Move2);
            move3 = GetMove(pokemon.Move3);
            move4 = GetMove(pokemon.Move4);
            move1_pp_ups = pokemon.Move1_PPUps;
            move2_pp_ups = pokemon.Move2_PPUps;
            move3_pp_ups = pokemon.Move3_PPUps;
            move4_pp_ups = pokemon.Move4_PPUps;


            if (pokemon.WasEgg == true && pokemon.EggMetDate != null)
            {
                was_egg = true;
                met_date = FormatMetDate((DateOnly)pokemon.EggMetDate);
            }
            else
            {
                if (pokemon.MetDate == null)
                {
                    pokemon.MetDate = new DateOnly();
                }

                met_level = pokemon.MetLevel;
                met_date = FormatMetDate((DateOnly)pokemon.MetDate);
            }

            met_location = GetLocation(pokemon.MetLocation);
            met_game = ExtractGame();
            trainer = new Trainer(pokemon, met_game);

            ribbons = ExtractRibbons();
        }

        protected abstract void Init();

        private string ExtractSpecies()
        {
            string? species = Enum.GetName(typeof(Species), pokemon.Species);
            return species == null ? throw new Exception("species not found") : FormatText(species);
        }

        private string ExtractNature()
        {
            string nature = Enum.GetName(typeof(Nature), pokemon.Nature) ?? "adamant";

            return FormatText(nature);
        }


        private string ExtractGender()
        {
            return pokemon.Gender switch
            {
                0 => "M",
                1 => "F",
                2 => "-",
                _ => "",
            };
        }

        private string ExtractBall()
        {
            string ball = Enum.GetName(typeof(Ball), pokemon.Ball) ?? "Poke";

            return FormatText(ball) + "-ball"; ;
        }


        private string ExtractAbility()
        {
            string ability = Enum.GetName(typeof(Ability), pokemon.Ability) ?? "unknown";
            return FormatText(ability);
        }


        protected abstract int ExtractBeauty();

        protected abstract int ExtractCool();

        protected abstract int ExtractCute();

        protected abstract int ExtractSheen();

        protected abstract int ExtractSmart();

        protected abstract int ExtractTough();


        private string ExtractGame()
        {
            string game = Enum.GetName(typeof(GameVersion), pokemon.Version) ?? "unknown";

            return FormatText(game);
        }

        protected List<string> ExtractRibbons()
        {
            List<String> savedRibbons = new List<string>();
            if (pokemon == null) { return savedRibbons; }

            List<RibbonInfo> ribbons = RibbonInfo.GetRibbonInfo(pokemon);
            foreach (RibbonInfo ribbon in ribbons)
            {
                if (ribbon.HasRibbon)
                {
                    savedRibbons.Add(ribbon.Name.ToLower());
                }
            }

            return savedRibbons;
        }

        protected virtual string GetLocation(int locationID)
        {
            string location = GameInfo.GetLocationName(false, (ushort)locationID, 0, pokemon.Generation, pokemon.Version);
            return FormatText(location);
        }

        private static string GetType(int typeID)
        {
            string type = Enum.GetName(typeof(Types), typeID) ?? "unknown";

            return FormatText(type);
        }

        private static string? GetMove(int moveID)
        {
            string? move = Enum.GetName(typeof(Move), moveID);
            if (move != null)
            {
                move = FormatText(move);
            }

            return move;
        }


        protected static string FormatText(string text)
        {

            text = text.ToLower();
            text = text.Replace(" ", "_");
            return text;
        }

        protected static string FormatMetDate(DateOnly dateonly)
        {
            var dates = dateonly.ToString().Split("/");
            string date = "{0}-{1}-{2}";
            date = string.Format(date, dates[2], dates[1], dates[0]);
            return date;
        }
    }
}
