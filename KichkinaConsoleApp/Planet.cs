class Planet 
{
    private Point planetCentrePoints;
    private int radius;
    public int Radius
    {
        get => radius;
        set
        {
            if (value > 1 || value < 1000)
                radius = value;
        }
    }

    public Planet(Point point, int radius)
    {
        planetCentrePoints = point;
        Radius = radius;
    }

    public bool IsTheCircle(Point point)
    {
        return Math.Sqrt(Math.Pow(point.X - planetCentrePoints.X, 2)
            + Math.Pow(point.Y - planetCentrePoints.Y, 2)) <= radius;
    }
}


