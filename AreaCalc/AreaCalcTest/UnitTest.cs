using AreaCalc;

namespace AreaCalcTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAreaCalc()
        {
            var t1 = new TriangleFigure(-1,5,0);
            Console.WriteLine(t1.Area);


            var s1 = new SquareFigure(-1);
            Console.WriteLine(s1.Area);


            var s2 = new SquareFigure(0);
            Console.WriteLine(s2.Area);
        }
    }
}