using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();


            // //=========================================================
            // //There is only one artist in this collection from Mount 
            // //Vernon. What is their name and age?
            // //=========================================================

            IEnumerable<Artist> ArtistList = Artists.Where(c => c.Hometown == "Mount Vernon");


            // //=========================================================
            // //Who is the youngest artist in our collection of artists?
            // //=========================================================

            int Youngest = Artists.Min(c => c.Age);
            List<string> YoungArtist = Artists.Where(c => c.Age == Youngest).Select(c => c.RealName).ToList();
            System.Console.WriteLine();
            // //=========================================================
            // //Display all artists with 'William' somewhere in their 
            // //real name        
            // //=========================================================

            List<string> William = Artists.Where(c => c.RealName.Contains("William")).Select(c => c.RealName).ToList();
            William.ForEach(System.Console.WriteLine);
            // //=========================================================
            // //Display all groups with names less than 8 characters
            // //=========================================================

            List<string> LessThanEight = Groups.Where(c => c.GroupName.Length < 8).Select(c => c.GroupName).ToList();

            // //=========================================================
            // //Display the 3 oldest artists from Atlanta
            // //=========================================================
            
            IEnumerable<int> Oldest = Artists.Where(c => c.Hometown == "Atlanta").OrderByDescending(c => c.Age).Select(c => c.Age).Take(3)
            .ToList();

 

            //=========================================================
            //(Optional) Display the Group Name of all groups that have 
            //at least one member not from New York City
            //=========================================================

            //=========================================================
            //(Optional) Display the artist names of all members of the 
            //group 'Wu-Tang Clan'
            //=========================================================
        }
    }
}
