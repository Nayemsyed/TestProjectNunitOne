namespace TestProjectNunitOne
{
    [TestFixture]
    public class Tests
    {
        OurLib.Calc calc;
        [SetUp]
        public void Setup()
        {
            calc=new OurLib.Calc();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void AddTest()
        {
            int n1 = 5;
            int n2 = 10;
            int result = 15;
            Assert.AreEqual(result,calc.Add(n1, n2));
        }
        [Test]
        public void DiffTest()
        {
            int n1 = 50;
            int n2 = 10;
            int result = 40;
            Assert.AreEqual(result, calc.Diff(n1, n2));
        }
        [Test]
        public void MultiTest()
        {
            int n1 = 5;
            int n2 = 10;
            int result = 50;
            Assert.AreEqual(result, calc.Multi(n1, n2));
        }
        [Test]
        public void AvgTest()
        {
            int n1 = 50;
            int n2 = 10;
            int result = 30;
            Assert.AreEqual(result, calc.Avg(n1, n2));
        }
    }
}