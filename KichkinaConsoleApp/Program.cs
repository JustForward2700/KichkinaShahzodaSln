Point prince = new Point(-5, 1);
Point princess = new Point(12, 1);

Planet[] planets = new Planet[]
{
    new Planet(new Point(1, 1), 8),
    new Planet(new Point(-3, -1), 1),
    new Planet(new Point(2, 2), 2),
    new Planet(new Point(5, 5), 1),
    new Planet(new Point(-4, 5), 1),
    new Planet(new Point(12, 1), 1),
    new Planet(new Point(12, 1), 2),
};

int result = 0;

foreach (Planet planet in planets)
    if (planet.IsTheCircle(prince) ^ planet.IsTheCircle(princess))
        result++;

//Natija: 3 chiqishi kerak to'g'ri javobda!
Console.WriteLine($"Natija: {result}");