using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    public int RowIndex { get; set; }
    public int ColIndex { get; set; }
    public bool IsDead { get; set; }
    public bool HasEscaped { get; set; }
    public Queue<char> Commands { get; set; }

    public Player(int row, int col, Queue<char> commands)
    {
        this.Commands = new Queue<char>(commands);
        this.RowIndex = row;
        this.ColIndex = col;
        this.IsDead = false;
        this.HasEscaped = false;
    }

    public void Move(char[,] lair)
    {
        char command = this.Commands.Dequeue();
        int newRowIndex = this.RowIndex;
        int newColIndex = this.ColIndex;

        if (command == 'U') newRowIndex--;
        else if (command == 'D') newRowIndex++;
        else if (command == 'L') newColIndex--;
        else if (command == 'R') newColIndex++;

        if (newRowIndex < 0 || newRowIndex == lair.GetLength(0) ||
            newColIndex < 0 || newColIndex == lair.GetLength(1))
        {
            this.HasEscaped = true;
        }
        else
        {
            this.RowIndex = newRowIndex;
            this.ColIndex = newColIndex;
        }
    }
}

internal class Program
{
    static void Main()
    {
        char[,] lair = GetLairData();
        (int playerRow, int playerCol) = GetInitialPlayerCoordinates(lair);
        lair[playerRow, playerCol] = '.';
        var commands = new Queue<char>(Console.ReadLine().ToCharArray());
        Player player = new Player(playerRow, playerCol, commands);

        while (!player.HasEscaped && !player.IsDead)
        {
            player.Move(lair);
            PopulateBunnies(lair);
            if (lair[player.RowIndex, player.ColIndex] == 'B')
            {
                player.IsDead = true;
            }
        }
        PrintResult(player, lair);
    }

    static char[,] GetLairData()
    {
        int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int n = size[0];
        int m = size[1];
        char[,] lair = new char[n, m];
        for (int row = 0; row < n; row++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int col = 0; col < m; col++)
            {
                lair[row, col] = line[col];
            }
        }
        return lair;
    }

    static (int, int) GetInitialPlayerCoordinates(char[,] lair)
    {
        for (int row = 0; row < lair.GetLength(0); row++)
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                if (lair[row, col] == 'P')
                    return (row, col);
            }
        return (0, 0);
    }

    static void PopulateBunnies(char[,] lair)
    {
        for (int row = 0; row < lair.GetLength(0); row++)
            for (int col = 0; col < lair.GetLength(1); col++)
                if (lair[row, col] == 'B')
                {
                    MarkNewBunniesLocations(lair, row, col);
                }
        CreateNewBunniesAtMarkedLocations(lair);
    }

    static void MarkNewBunniesLocations(char[,] lair, int row, int col)
    {
        // Mark the coordinates of new bunny locations with 'N'
        if (row + 1 < lair.GetLength(0) && lair[row + 1, col] != 'B')
            lair[row + 1, col] = 'N';
        if (row - 1 >= 0 && lair[row - 1, col] != 'B')
            lair[row - 1, col] = 'N';
        if (col + 1 < lair.GetLength(1) && lair[row, col + 1] != 'B')
            lair[row, col + 1] = 'N';
        if (col - 1 >= 0 && lair[row, col - 1] != 'B')
            lair[row, col - 1] = 'N';
    }

    static void CreateNewBunniesAtMarkedLocations(char[,] lair)
    {
        // Replace the N's with B's
        for (int row = 0; row < lair.GetLength(0); row++)
            for (int col = 0; col < lair.GetLength(1); col++)
                if (lair[row, col] == 'N')
                {
                    lair[row, col] = 'B';
                }
    }

    static void PrintResult(Player player, char[,] lair)
    {
        for (int row = 0; row < lair.GetLength(0); row++)
        {
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                Console.Write(lair[row, col]);
            }
            Console.WriteLine();
        }

        if (player.HasEscaped) Console.Write("won: ");
        else if (player.IsDead) Console.Write("dead: ");
        Console.WriteLine($"{player.RowIndex} {player.ColIndex}");
    }
}