using C__Review_for_Server_Side;
using System.Xml.Linq;
using System;


string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
string filePath = projectFolder + Path.DirectorySeparatorChar + "videogames.csv";

List<VideoGame> game = new List<VideoGame>();

using (var sr = new StreamReader(filePath))
{
    string fileHeader = sr.ReadLine();
    while(!sr.EndOfStream)
    {
        string? line = sr.ReadLine();
        string[] lineElements = line.Split(',');

        VideoGame vg = new VideoGame()
        {
            Name = lineElements[0],
            Platform = lineElements[1],
            Year = Double.Parse(lineElements[2]),
            Genre = lineElements[3],
            Publisher = lineElements[4],
            NA_Sales = Double.Parse(lineElements[5]),
            EU_Sales = Double.Parse(lineElements[6]),
            JP_Sales = Double.Parse(lineElements[7]),
            Other_Sales = Double.Parse(lineElements[8]),
            Global_Sales = Double.Parse(lineElements[9])
        };

        game.Add(vg);
    }
}

game.Sort();

var nintendo = game.Where(vg => vg.Publisher == "Nintendo");
foreach (var vg in nintendo) Console.WriteLine(vg);
Console.WriteLine("\n\n");

Console.WriteLine("What publisher would you like to see data from: ");
string publisher = Console.ReadLine();
PublisherData(game, publisher);

static void PublisherData(List<VideoGame> game, string publisher)
{
    float numGame = game.Count;
    var specPub = new List<VideoGame>();
    foreach (VideoGame vg in game)
    {
        if (vg.Publisher == publisher) 
            specPub.Add(vg);
    }
    float numPub = specPub.Count;
    var percentage = numPub / numGame * 100;
    foreach (var vg in specPub) Console.WriteLine(vg);
    Console.WriteLine($"There are {numPub} games made by {publisher} out of {numGame} games which is {percentage:0.##}%");
 
}


Console.WriteLine("What genre would you like to see data from: ");
string genre = Console.ReadLine();
GenreData(game, genre);

static void GenreData(List<VideoGame> game, string genre)
{
    float numGame = game.Count;
    var specGenre = new List<VideoGame>();
    foreach (VideoGame vg in game)
    {
        if (vg.Genre == genre) 
            specGenre.Add(vg);
    }

    float numGenre = specGenre.Count;
    var percentage = numGenre / numGame * 100;
    foreach (var vg in specGenre) Console.WriteLine(vg);
    Console.WriteLine($"There are {numGenre} games in the {genre} genre out of {numGame} games which is {percentage:0.##}%");
}





