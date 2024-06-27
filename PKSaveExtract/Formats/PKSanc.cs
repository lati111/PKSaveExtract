using PKSaveExtract.Models;

namespace PKSaveExtract.Formats
{
    internal class PKSanc : IFormat
    {
        public uint PID { get; set; }
        public string? Nickname { get; set; }
        public string Species { get; set; }
        public int Form { get; set; }
        public string Ability { get; set; }
        public string Nature { get; set; }
        public string Gender { get; set; }
        public int Level { get; set; }
        public int Friendship { get; set; }
        public string Ball { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool Is_shiny { get; set; }

        public int HP_power { get; set; }
        public string HP_type { get; set; }

        public int Beauty { get; set; }
        public int Cool { get; set; }
        public int Cute { get; set; }
        public int Sheen { get; set; }
        public int Smart { get; set; }
        public int Tough { get; set; }

        public int HP_IV { get; set; }
        public int ATK_IV { get; set; }
        public int DEF_IV { get; set; }
        public int SPA_IV { get; set; }
        public int SPD_IV { get; set; }
        public int SPE_IV { get; set; }

        public int HP_EV { get; set; }
        public int ATK_EV { get; set; }
        public int DEF_EV { get; set; }
        public int SPA_EV { get; set; }
        public int SPD_EV { get; set; }
        public int SPE_EV { get; set; }

        public string? Move1 { get; set; }
        public int? Move1_pp_ups { get; set; }
        public string? Move2 { get; set; }
        public int? Move2_pp_ups { get; set; }
        public string? Move3 { get; set; }
        public int? Move3_pp_ups { get; set; }
        public string? Move4 { get; set; }
        public int? Move4_pp_ups { get; set; }

        public bool Was_egg { get; set; }
        public string Met_date { get; set; }
        public string Met_location { get; set; }
        public string Met_game { get; set; }
        public int Met_level { get; set; }

        public string Tera_type { get; set; }
        public bool Is_alpha { get; set; }
        public bool Has_n_sparkle { get; set; }
        public bool Can_gigantamax { get; set; }
        public int Dynamax_level { get; set; }

        public string? Ribbons { get; set; }

        public int Trainer_SID { get; set; }
        public int Trainer_TID { get; set; }
        public string Trainer_name { get; set; }
        public string Trainer_gender { get; set; }
        public string Trainer_game { get; set; }
        public string Version { get; set; }

        public PKSanc(AbstractPokemon pokemon)
        {
            PID = pokemon.PID;
            Nickname = pokemon.nickname;
            Species = pokemon.species;
            Form = pokemon.form;
            Ability = pokemon.ability;
            Nature = pokemon.nature;
            Gender = pokemon.gender;
            Level = pokemon.level;
            Friendship = pokemon.friendship;
            Ball = pokemon.ball;
            Height = pokemon.height;
            Weight = pokemon.weight;

            Tera_type = pokemon.tera_type;
            HP_power = pokemon.HP_power;
            HP_type = pokemon.HP_type;

            HP_EV = pokemon.HP_EV;
            ATK_EV = pokemon.ATK_EV;
            DEF_EV = pokemon.DEF_EV;
            SPA_EV = pokemon.SPA_EV;
            SPD_EV = pokemon.SPD_EV;
            SPE_EV = pokemon.SPE_EV;

            HP_IV = pokemon.HP_IV;
            ATK_IV = pokemon.ATK_IV;
            DEF_IV = pokemon.DEF_IV;
            SPA_IV = pokemon.SPA_IV;
            SPD_IV = pokemon.SPD_IV;
            SPE_IV = pokemon.SPE_IV;

            Beauty = pokemon.beauty;
            Cool = pokemon.cool;
            Cute = pokemon.cute;
            Sheen = pokemon.sheen;
            Smart = pokemon.smart;
            Tough = pokemon.tough;

            Move1 = pokemon.move1;
            Move2 = pokemon.move2;
            Move3 = pokemon.move3;
            Move4 = pokemon.move4;
            Move1_pp_ups = pokemon.move1_pp_ups;
            Move2_pp_ups = pokemon.move2_pp_ups;
            Move3_pp_ups = pokemon.move3_pp_ups;
            Move4_pp_ups = pokemon.move4_pp_ups;

            Met_date = pokemon.met_date;
            Met_location = pokemon.met_location;
            Met_game = pokemon.met_game;
            Met_level = pokemon.met_level;

            Trainer_SID = pokemon.trainer.SID;
            Trainer_TID = pokemon.trainer.TID;
            Trainer_name = pokemon.trainer.name;
            Trainer_gender = pokemon.trainer.gender;
            Trainer_game = pokemon.trainer.game;

            Ribbons = GetRibbonString(pokemon.ribbons);

            Was_egg = pokemon.was_egg;
            Is_shiny = pokemon.is_shiny;
            Is_alpha = pokemon.is_alpha;
            Can_gigantamax = pokemon.can_gigantamiax;
            Has_n_sparkle = pokemon.has_n_sparkle;
            Dynamax_level = pokemon.dynamax_level;

            Version = "v1.2";
        }

        private static string GetRibbonString(List<string> ribbons)
        {
            return String.Join("|", ribbons);
        }
    }
}
