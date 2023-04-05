# PKHeX-extract
PKHeX-extract is a lightweight tool that extracts Pokemon data from a save file and exports it as a csv file. 
It uses the [PKHeX](https://github.com/kwsch/PKHeX) .NET library for the reading of save files, and the [CsvHelper](https://joshclose.github.io/CsvHelper) library for the generating of save files.

### Csv Formats
PKHeX-extract supports multiple csv formats to maximize flexibility. If you wish to create a custom format that is entirely possible and easy to do. An guide on how to do so will be made available in the [wiki](https://github.com/lati111/PKHeX-extract/wiki) later, as well as how to submit it to be bundled with PKHeX-extract.
Currently, the following formats come bundled with PKHeX-extract:

##### PokeSanc Csv
This csv format is meant to be used in [PokeSanc](https://ironbrain.io/pokesanc)'s import feature, and features a large amount of data about both the pokemon and the trainer alike, including ribbons. A full list of contained data can be found [here](https://github.com/lati111/PKHeX-extract/wiki/PokeSanc-Csv).
