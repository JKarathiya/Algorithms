using Xunit;

namespace HowManyFlips
{
    public class SolutionTests
    {
        public Solution _solution;
        public SolutionTests()
        {
            // arrange
            _solution = new Solution();
        }

        [InlineData("01011", 3)]
        [InlineData("0011", 1)]
        [Theory]
        public void HowManyFlips_ForInputes_ReturnsExpectedResult(string input, int expected)
        {
            // act
            var result = _solution.HowManyFlips(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
