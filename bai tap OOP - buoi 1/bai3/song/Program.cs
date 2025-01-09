﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace song
{
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // nhap so luong bai hat
            Console.WriteLine("nhap so luong bai hat:");
            int numSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            // nhap thong tin bai hat
            for (int i = 0; i < numSongs; i++)
            {
                Console.WriteLine($"nhap thong tin bai hat {i + 1} (dinh dang: loai_ten_thoi gian):");
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song
                {
                    TypeList = type,
                    Name = name,
                    Time = time
                };

                songs.Add(song);
            }

            // nhap loai bai hat can loc
            Console.WriteLine("nhap loai bai hat hoac 'all' de hien thi tat ca:");
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
