namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sumator_SumTwoPossitiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -2 };
            var actual = Summator.Sum(nums);
            var expected = -3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        /*[SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }*/
    }
}