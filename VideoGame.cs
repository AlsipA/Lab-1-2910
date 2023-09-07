using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Review_for_Server_Side
{
    public class VideoGame: IComparable<VideoGame>
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public double Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public double NA_Sales { get; set; }
        public double EU_Sales { get; set; }
        public double JP_Sales { get; set; }
        public double Other_Sales { get; set; }
        public double Global_Sales { get; set; }

        public VideoGame() { }

        public VideoGame(string name, string platform, double year, string genre, string publisher, double na_sales, double eu_sales, double jp_sales, double other_sales, double global_sales)
        {
            Name = name;
            Platform = platform;
            Year = year;
            Genre = genre;
            Publisher = publisher;
            NA_Sales = na_sales;
            EU_Sales = eu_sales;
            JP_Sales = jp_sales;
            Other_Sales = other_sales;
            Global_Sales = global_sales;
        }

        public int CompareTo(VideoGame? other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            string videoGameString = "";
            videoGameString += $"Name: {Name}\n";
            videoGameString += $"Platform: {Platform}\n";
            videoGameString += $"Year Released: {Year}\n";
            videoGameString += $"Genre: {Genre}\n";
            videoGameString += $"Publisher: {Publisher}\n";
            videoGameString += $"North America Sales: {NA_Sales}\n";
            videoGameString += $"European Sales: {EU_Sales}\n";
            videoGameString += $"Japanese Sales: {JP_Sales}\n";
            videoGameString += $"Other Sales: {Other_Sales}\n";
            videoGameString += $"Global Sales: {Global_Sales}\n";
            return videoGameString;
        }
    }
}
