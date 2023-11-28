using Xunit;

namespace ValidateBrackets
{
    public class SolutionTests
    {
        public Solution _solution;
        public SolutionTests()
        {
            // arrange
            _solution = new Solution();
        }

        [Theory]
        [InlineData("This is a (valid) string", true)]
        [InlineData("This is not ( a valid string", false)]
        [InlineData("This (is also a (valid)) string", true)]
        [InlineData("this is )not a valid( string", false)]
        public void ValidateBrackets_Result(string input, bool expected)
        {
            // act
            var result = _solution.ValidateBrackets(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
