using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int width = int.Parse(inputs[0]);
        int height = int.Parse(inputs[1]);
        int boxCount = int.Parse(inputs[2]);
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
        }

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int pusherX = int.Parse(inputs[0]);
            int pusherY = int.Parse(inputs[1]);
            for (int i = 0; i < boxCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int boxX = int.Parse(inputs[0]);
                int boxY = int.Parse(inputs[1]);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("U");
        }
    }
}