struct Point
{
    private int x;
    private int y;

    public int X
    {
        get => x;
        set
        {
            if (value > 1000 || value < -1000)
                throw new ArgumentOutOfRangeException(
                    "Kiritilgan koordinata -1000 va 1000 oralig'ida bo'lishi kerak!");
            else
                x = value;
        }
    }
    public int Y
    {
        get => y;
        set
        {
            if (value > 1000 || value < -1000)
                throw new ArgumentOutOfRangeException(
                    "Kiritilgan koordinata -1000 va 1000 oralig'ida bo'lishi kerak!");
            else
                y = value;
        }
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(string? stringCoordinates)
    {
        var coordinates = stringCoordinates?
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        if (coordinates is { Length: 2 })
        {
            X = coordinates[0];
            Y = coordinates[1];
        }
        else
        {
            Console.WriteLine("Iltimos nuqtaning koordinatalarini to'g'ri kiriting!");
            new Point(Console.ReadLine());
        }
    }
}




