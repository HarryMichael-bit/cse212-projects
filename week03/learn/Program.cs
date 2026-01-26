using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n======================\nDuplicate Counter\n======================");
        DuplicateCounter.Run();

        Console.WriteLine("\n======================\nTranslator\n======================");
        Translator.Run();

        // Maze Test
        Console.WriteLine("\n======================\nMaze Test\n======================");

        var mazeMap = new Dictionary<(int, int), bool[]>
        {
            {(1,1), new bool[]{false, true, false, false}}, // can only move right
            {(2,1), new bool[]{true, false, true, false}}, // can move left or up
            {(2,2), new bool[]{false, false, false, true}} // can move down
        };

        var maze = new Maze(mazeMap);

        Console.WriteLine(maze.GetStatus()); // (x=1, y=1)
        maze.MoveRight();
        Console.WriteLine(maze.GetStatus()); // (x=2, y=1)
        maze.MoveUp();
        Console.WriteLine(maze.GetStatus()); // (x=2, y=2)

        try
        {
            maze.MoveRight(); //blocked
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // "Can't go that way!"
        }

    }
}
