using System;
using System.Collections.Generic;
class Playlist
{
    private List<string> songs;
    public Playlist()
    {
        songs = new List<string>();
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < songs.Count)
            {
                return songs[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
        set
        {
            if (index >= 0 && index < songs.Count)
            {
                songs[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
    // Method to add a song to the playlist
    public void AddSong(string song)
    {
        songs.Add(song);
    }

    public void DisplayPlaylist()
    {
        Console.WriteLine("Playlist:");
        for (int i = 0; i < songs.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {songs[i]}");
        }
    }
}
class Program
{
    static void Main()
    {
        Playlist myPlaylist = new Playlist();
        myPlaylist.AddSong("Song 1");
        myPlaylist.AddSong("Song 2");
        myPlaylist.AddSong("Song 3");
        myPlaylist.DisplayPlaylist();
        Console.WriteLine("\nAccessing songs by position:");
        Console.WriteLine("Song at position 1: " + myPlaylist[0]);
        Console.WriteLine("Song at position 2: " + myPlaylist[1]);
        Console.WriteLine("Song at position 3: " + myPlaylist[2]);
    }
}