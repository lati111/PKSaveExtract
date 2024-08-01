using PKHeX.Core;
using PKSaveExtract.Formats;
using PKSaveExtract.Formatters;
using PKSaveExtract.Models;
using System.Reflection;


namespace PKSaveExtract
{
    public partial class PKSaveExtract : Form
    {
        private readonly List<Type> formatList;
        private string? saveFilePath;

        public PKSaveExtract()
        {
            InitializeComponent();
            formatList = PopulateFormatPicker();
        }

        private List<Type> PopulateFormatPicker()
        {
            var FormatList = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.Namespace == "PKSaveExtract.Formats")
                    .Where(t => t.Name != "IFormat")
                    .ToList();

            foreach (var Format in FormatList)
            {
                FormatPicker.Items.Add(Format.Name);
            }

            return FormatList;
        }

        private void BrowseSaveFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = file.FileName;
                SaveFilePathDisplay.Text = saveFilePath;
            }
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            List<PKM>? pkmnCollection = ExtractSaveData();
            if (pkmnCollection == null)
            {
                return;
            }

            AbstractFormatter? formatter = GetFormatter();
            if (formatter == null)
            {
                return;
            }

            List<AbstractPokemon> pokemonCollection = new();
            pkmnCollection.ForEach(pkmn =>
            {
                AbstractPokemon? pokemon = ConvertPokemon(pkmn);
                if (pokemon == null)
                {
                    return;
                }

                if (pkmn.PID != 0 && pkmn.Species.ToString() != "none")
                {
                    pokemonCollection.Add(pokemon);
                }

            });

            List<IFormat> dataCollection = formatter.Format(pokemonCollection);
            string? savePath = PromptSaveLocation(GetSaveFileName());
            if (savePath == null)
            {
                return;
            }

            formatter.ExportCsv(savePath, dataCollection);
            ShowSuccess("Save file exported!");
        }



        private AbstractFormatter? GetFormatter()
        {
            string FormatName = FormatPicker.Text;
            Type FormatterType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "PKSaveExtract.Formatters")
                .Where(t => t.Name == FormatName + "Formatter")
                .First();

            var formatter = Activator.CreateInstance(FormatterType);

            if (formatter == null || formatter is not AbstractFormatter)
            {
                ShowError("The selected format could not be loaded");
                return null;
            }

            return (AbstractFormatter)formatter;
        }

        private List<PKM>? ExtractSaveData()
        {
            if (saveFilePath == null)
            {
                ShowError("A save file must be selected");
                return null;
            }

            List<PKM> data = new();
            SaveFile? sav = SaveUtil.GetVariantSAV(saveFilePath);
            if (sav == null)
            {
                ShowError("This is not a PKHeX supported save file");
                return null;
            }

            data.AddRange(sav.BoxData.ToList());
            data.AddRange(sav.PartyData.ToList());

            return data;
        }

        private string GetSaveFileName()
        {
            if (saveFilePath == null)
            {
                ShowError("A save file must be selected");
                return "";
            }

            return saveFilePath.Split("\\").Last();
        }

        private AbstractPokemon? ConvertPokemon(PKM pkmn)
        {
            switch (pkmn.Extension)
            {
                case "pk3":
                    return new Gen3Pokemon(pkmn);
                case "pk4":
                    return new Gen4Pokemon(pkmn);
                case "pk5":
                    return new Gen5Pokemon(pkmn);
                case "pk6":
                    return new Gen6Pokemon(pkmn);
                case "pk7":
                    return new Gen7Pokemon(pkmn);
                case "pk8":
                    return new Gen8Pokemon(pkmn);
                case "pa8":
                    return new Gen8ArceusPokemon(pkmn);
                case "pk9":
                    return new Gen9Pokemon(pkmn);
                default:
                    ShowError("Only pokemon from generation 3 through 9 are supported");
                    return null;
            }
        }

        private static string? PromptSaveLocation(string fileName)
        {
            SaveFileDialog SaveDialog = new();
            SaveDialog.FileName = fileName + ".csv";
            SaveDialog.Title = SaveDialog.Title = "Export a Save File";
            SaveDialog.Filter = "csv (*.csv)|*.csv|All files (*.*)|*.*";
            SaveDialog.FilterIndex = 1;
            SaveDialog.RestoreDirectory = true;
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                return SaveDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        private static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private static void ShowError(string message)
        {
            MessageBox.Show(message, "An error has occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}