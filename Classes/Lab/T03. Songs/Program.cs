using System;
using System.Collections.Generic;

namespace T03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
           
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputArguments = Console.ReadLine()
                    .Split('_');
                string typeList = inputArguments[0];
                string name = inputArguments[1];
                string time = inputArguments[2];
                
                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string listName = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currSong = songs[i];
                if (listName == "all")
                {
                    Console.WriteLine(currSong.Name);
                }
                else if (listName == currSong.TypeList)
                {
                    Console.WriteLine(currSong.Name);
                }
            }
        }
    }
    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
