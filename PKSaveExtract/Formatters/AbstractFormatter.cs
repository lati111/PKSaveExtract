using PKSaveExtract.Formats;
using PKSaveExtract.Models;

namespace PKSaveExtract.Formatters
{
    internal abstract class AbstractFormatter
    {
        public abstract List<IFormat> Format(List<AbstractPokemon> pokemonCollection);
        public abstract void ExportCsv(string path, List<IFormat> pokemonCollection);
    }
}
