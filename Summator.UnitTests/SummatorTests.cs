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

        [Test]
        public void Test_Sumator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);
            var expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_ThreePositiveNumbers()
        {
            // Arrange
            var nums = new int[] { 4, 5, 90 };
            var expected = 99;

            // Act
            var actual = Summator.Sum(nums);

            // Assert

            // Assertion Classic Model
            // Assert.AreEqual(expected, actual);

            // Assertion Constraint Model
            Assert.That(expected, Is.EqualTo(actual));

            Assert.False(9 == 8);
            Assert.That(9, Is.Not.EqualTo(8));
        }

        [Test]
        public void AssertionsExample() 
        {
            // Assert boolean condition
            Assert.That(9 == 9);
            Assert.That(9, Is.GreaterThan(6));

            // Range assertions
            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            // String assertion
            Assert.That("I want to become the best QA", Does.Contain("QA"));

            // regex
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            // Assertion for expected exeption
            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());
            Assert.That(() => "abs"[45], Throws.InstanceOf<Exception>());

            //Assert.That(() => Summator.Sum(new int[] { 3, 4, 5}), Throws.TypeOf<IndexOutOfRangeException>());

            // Collection assertion
            Assert.That(new int[] { 4, 5, 6}, Has.Member(6));

            // Collection range assertion
            var percentages = new int[] { 10, 23, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));

            //Assert.That(percentage, Is.EqualTo(100), "sumata, koqto se vrysta");
        }

        [Test]
        public void Test_Sumator_AverageTwoPossitiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Average(nums);
            var expected = 1.5;

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