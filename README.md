# PKSaveExtract
PKSaveExtract is a lightweight tool that extracts Pokemon data from a save file and exports it as a csv file. 
It uses the [PKHeX](https://github.com/kwsch/PKHeX) .NET library for the reading of save files, and the [CsvHelper](https://joshclose.github.io/CsvHelper) library for the generating of save files.

### Csv Formats
PKSaveExtract supports multiple csv formats to maximize flexibility. If you wish to create a custom format that is entirely possible and easy to do. An guide on how to do so will be made available in the [wiki](https://github.com/lati111/PKSaveExtract/wiki) later, as well as how to submit it to be bundled with PKHeX-extract.
Currently, the following formats come bundled with PKHeX-extract:

##### PKSanc csv (version 1.2)
This csv format is meant to be used in [PKSanc](https://ironbrain.io/pksanc)'s import feature, and features a large amount of data about both the pokemon and the trainer alike, including ribbons. A full list of contained data can be found [on the relevant wiki page](https://github.com/lati111/PKHeX-extract/wiki/PokeSanc-Csv).
