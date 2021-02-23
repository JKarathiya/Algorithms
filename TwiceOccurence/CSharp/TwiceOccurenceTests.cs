using Xunit;

namespace TwiceOccurences
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
        [InlineData("aba", "a")]
        [InlineData("zz", "z")]
        [InlineData("bob", "b")]
        public void FindMaxWords_Sentence_Result(string input, string expected)
        {
            // act
            var result = _solution.TwiceOccurence(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
