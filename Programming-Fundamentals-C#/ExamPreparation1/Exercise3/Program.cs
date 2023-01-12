using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    public class Program
    {
        public static void Main()
        {
            List<Pianist> pieces = new List<Pianist>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split('|');
                string piece = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];
                Pianist pianist = new Pianist(piece, composer, key);
                pieces.Add(pianist);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split('|');
                string action = command[0];

                if (action == "Stop")
                {
                    foreach (var pianist in pieces)
                        Console.WriteLine($"{pianist.Piece} -> Composer: {pianist.Composer}, Key: {pianist.Key}");
                    break;
                }

                string piece = command[1];
                if (action == "Add")
                {
                    string composer = command[2];
                    string key = command[3];

                    if (pieces.Any(p => p.Piece == piece)) 
                        Console.WriteLine($"{piece} is already in the collection!");
                    else
                    {
                        Pianist pianist = new Pianist(piece, composer, key);
                        pieces.Add(pianist);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (pieces.Any(p => p.Piece == piece))
                        Console.WriteLine($"Successfully removed {piece}!");
                    else
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
                else if (action == "ChangeKey")
                {
                    string newKey = command[2];

                    if (pieces.Any(p => p.Piece == piece))
                    {
                        pieces.First(p => p.Piece == piece).Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }
        }
    }

    public class Pianist
    {
        public Pianist(string piece, string composer, string key)
        {
            Piece = piece;
            Composer = composer;
            Key = key;
        }

        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}