public record MapObject(int X, int Y)
{
    public static MapObject Parse(string line)
    {
        var inputs = line.Split(' ');
        var x = int.Parse(inputs[0]);
        var y = int.Parse(inputs[1]);

        return new(x, y);
    }
}

public class Map
{
    public readonly IReadOnlyList<string> Grid;

    public Map(IReadOnlyList<string> grid)
    {
        Grid = grid;
    }

    public bool IsFree(int x, int y)
    {
        if (0 > y || y >= Grid.Count) return false;
        var line = Grid[y];
        if (0 > x || x >= line.Length) return false;
        return line[x] != '#';
    }

    public int GetScore(IEnumerable<MapObject> boxes)
    {
    }
}

internal static class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        var width = int.Parse(inputs[0]);
        var height = int.Parse(inputs[1]);
        var boxCount = int.Parse(inputs[2]);

        var lines = new string[height];

        for (var i = 0; i < height; i++)
        {
            var line = Console.ReadLine();
            lines[i] = line!;
            Console.Error.WriteLine(line);
        }

        var map = new Map(lines);

        // game loop
        while (true)
        {
            var pusher = MapObject.Parse(Console.ReadLine());

            for (var i = 0; i < boxCount; i++)
            {
                var box = MapObject.Parse(Console.ReadLine());
            }

            Console.WriteLine("U");
        }
    }
}