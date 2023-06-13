using AreaCalc;

namespace AracCalcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип фигуры");
            var typeName = Console.ReadLine();
            try
            {
                switch (typeName)
                {
                    case "Круг": 
                    case "круг":
                        Console.WriteLine("Введите радиус окружности");
                        double r;
                        if (Double.TryParse(Console.ReadLine(), out r))
                        {
                            var square = new SquareFigure(r);
                            Console.WriteLine($"Площадь окружности {square.Area}");
                        }
                        else
                            throw new Exception("Неверный окружности");

                        break;
                    case "Треугольник":
                    case "треугольник":
                        Console.WriteLine("Введите стороны треугольника через запятую");
                        string[] sides = Console.ReadLine().Split(',');
                        double s1, s2, s3;
                        if (Double.TryParse(sides[0], out s1) && Double.TryParse(sides[1], out s2) && Double.TryParse(sides[2], out s3))
                        {
                            var triangle = new TriangleFigure(s1, s2, s3);
                            Console.WriteLine($"Площадь треугольника {triangle.Area}");
                            string isRight = triangle.isRightTriangle ? "прямоугольный" : "не прямоугольный";
                            Console.WriteLine($"Треугольник {isRight}");
                        }
                        else
                                throw new Exception("Неверные стороны треугольника");
                        break;
                    default:
                        throw new Exception("Неверный тип");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при вычислении площади: {e.Message}");
            }
        }
    }
}