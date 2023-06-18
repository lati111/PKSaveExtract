using CsvHelper;
using PKSaveExtract.Formats;
using PKSaveExtract.Models;
using System.Globalization;

namespace PKSaveExtract.Formatters
{
    internal class PKSancFormatter : AbstractFormatter
    {
        public override List<IFormat> Format(List<AbstractPokemon> pokemonCollection)
        {
            List<IFormat> OutputCollection = new();
            pokemonCollection.ForEach(pokemon => {
                OutputCollection.Add(new PKSanc(pokemon));
            });
            return OutputCollection;
        }


        public override void ExportCsv(string path, List<IFormat> pokemonCollection)
        {
            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(pokemonCollection.Cast<PKSanc>());
        }
    }
}
