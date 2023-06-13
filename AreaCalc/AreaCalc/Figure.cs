namespace AreaCalc
{
    public class SquareFigure : IFigureInterface
    {
        public const string FigureName = "Квадрат";

        private double radius;

        public SquareFigure(double radius)
        {
            Radius = radius;
        }

        public double Radius 
        { 
            get { return radius; } 
            set 
            { 
                radius = value; 
            } 
        }

        public double Area {
            get => Math.Pow(this.radius, 2) * Math.PI;
        }
    }


    public class TriangleFigure : IFigureInterface
    {
        public const string FigureName = "Треугольник";

        private double firstSide;
        public double FirstSide
        {
            get { return firstSide; }
            set
            {
                firstSide = value;
            }
        }


        private double secondSide;
        public double SecondSide
        {
            get { return secondSide; }
            set
            {
                secondSide = value;
            }
        }


        private double thirdSide;

        public TriangleFigure(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double ThirdSide
        {
            get { return thirdSide; }
            set
            {
                thirdSide = value;
            }
        }

        private double pperimeter => (firstSide + secondSide + thirdSide)/2;

        public double Area
        {
            get => Math.Sqrt(pperimeter*(pperimeter - firstSide)*(pperimeter - secondSide)*(pperimeter - thirdSide));
        }

        public bool isRightTriangle
        {
            get {
                bool yes = false;
                yes = Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) || yes;

                yes = Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) || yes;

                yes = Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) || yes;
                return yes;
            }
        }
    }
}