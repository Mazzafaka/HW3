// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53





    class Program 
    {
        static void Main(string[] args)
        {
            DistanceCalculator program = new DistanceCalculator();
            program.Run();
        }
    }

    public class DistanceCalculator
    {
        public void Run()
        {
            Console.WriteLine("Введите координаты точки A:");
            double x1 = GetCoordinate("x");
            double y1 = GetCoordinate("y");
            double z1 = GetCoordinate("z");

            Console.WriteLine("Введите координаты точки B:");
            double x2 = GetCoordinate("x");
            double y2 = GetCoordinate("y");
            double z2 = GetCoordinate("z");

            Point3D pointA = new Point3D(x1, y1, z1);
            Point3D pointB = new Point3D(x2, y2, z2);

            double distance = Distance3D(pointA, pointB);
            Console.WriteLine($"Расстояние между точкой A и точкой B: {distance:F2}");
        }

        private double GetCoordinate(string coordinateName)
        {
            Console.Write($"Введите {coordinateName}: ");
            string input = Console.ReadLine();
            double coordinate;
            while (!double.TryParse(input, out coordinate))
            {
                Console.WriteLine("Неверный формат. Пожалуйста, введите число.");
                Console.Write($"Введите {coordinateName}: ");
                input = Console.ReadLine();
            }
            return coordinate;
        }

        private double Distance3D(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2) + Math.Pow(point2.Z - point1.Z, 2));
            return distance;
        }
    }

    public class Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
