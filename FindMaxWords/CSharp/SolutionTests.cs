using Xunit;

namespace RollercoasterWord
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
        [InlineData("We test coders. Give us a try?", 4)]
        [InlineData("Forget Cvs..Save time . x x", 2)]
        public void FindMaxWords_Sentence_Result(string input, int expected)
        {
            // act
            var result = _solution.FindMaxWords(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
