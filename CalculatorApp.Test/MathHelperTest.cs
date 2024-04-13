namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var calculator = new MathFormulas();

            int a = 3; int b = 4; int c = 5;

            var aResult = calculator.IsEven(a);
            var bResult = calculator.IsEven(b);
            var cResult = calculator.IsEven(c);

            Assert.False(aResult);
            Assert.True(bResult);
            Assert.False(cResult);
        }

        [Theory]
        [InlineData(4, 5, 1)]
        public void DiffTest(int x, int y, int expectedResult)
        {
            var calculator1 = new MathFormulas();
            var result = calculator1.Diff(x, y);
            Assert.Equal(expectedResult, result);
        }

        [Theory, InlineData(new int[4] { 3, 2, 4, 5 }, 14)]
        public void SummTest(int[] values, int expectedResult)
        {
            var calculator = new MathFormulas();
            var result = calculator.Sum(values);
            Assert.Equal(result, expectedResult);
        }

        [Theory(Skip ="Reason is another test named Add_ClassData_Test"), InlineData(5, 6, 11)]
        public void AddTest(int a, int b, int expectedResult)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory, InlineData(new int[4] {3, 6, 5, 6},  5)]
        public void AverageTest(int[] values, int expectedResult)
        {
            var calculator = new MathFormulas();
            var result = calculator.Average(values);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [ClassData(typeof(MathFormulas))]

        public void Add_ClassData_Test(int x, int y, int expectedResult)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(expectedResult, result);
        }
    }
}