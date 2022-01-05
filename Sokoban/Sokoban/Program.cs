using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        var width = int.Parse(inputs[0]);
        var height = int.Parse(inputs[1]);
        var boxCount = int.Parse(inputs[2]);

        var map = new string[height];
        
        for (var i = 0; i < height; i++)
        {
            var line = Console.ReadLine();
            map[i] = line!;
            Console.Error.WriteLine(line);
        }

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            var pusherX = int.Parse(inputs[0]);
            var pusherY = int.Parse(inputs[1]);
            for (var i = 0; i < boxCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                var boxX = int.Parse(inputs[0]);
                var boxY = int.Parse(inputs[1]);
            }

            Console.WriteLine("U");
        }
    }
}