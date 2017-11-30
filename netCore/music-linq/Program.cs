using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

                //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // var fg = Artists.Where(c => c.Hometown == "Mount Vernon").ToList();
            // foreach(var n in fg) System.Console.WriteLine($"Their Name: {n.ArtistName}\nTheir Age: {n.Age}");
                //Who is the youngest artist in our collection of artists?
            // var yg = Artists.OrderBy(age => age.Age).FirstOrDefault();
            // System.Console.WriteLine($"The youngest artist is {yg.ArtistName}");
                //Display all artists with 'William' somewhere in their real name
            // var w = Artists.Where(c => c.RealName.Contains("William"));
            // Console.WriteLine("These artists have 'William' in their real names:");
            // foreach (var wi in w) System.Console.WriteLine($"\t{wi.ArtistName}");
                //Display the 3 oldest artist from Atlanta
            // var o = Artists.Where(x => x.Hometown == "Atlanta").OrderByDescending(c => c.Age);
            // int count = 0;
            // System.Console.WriteLine("Here are the 3 oldest artists from Atlanta");
            // foreach (var i in o)
            // {
            //     count++;
            //     if (count == 4)
            //     {
            //         break;
            //     }
            //     System.Console.WriteLine($"{i.ArtistName}, {i.Age}");
            // }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
