using Xunit;

namespace MindeletionsProblem
{
    public class SolutionTests
    {
        public Solution _solution;
        public SolutionTests()
        {
            // arrange
            _solution = new Solution();
        }

        [Theory(DisplayName = "Check that a short rollercoaster word returns true.")]
        [InlineData("eeeeffff", 1)]
        [InlineData("eeeeffffaaaa", 3)]
        [InlineData("aabbffddeaee", 6)]
        [InlineData("llll", 0)]
        [InlineData("example", 4)]
        public void MinDeletions_MindeletionsProblem_ReturnsTrue(string input, int expected)
        {
            // act
            var result = _solution.MinDeletions(input);

            // assert
            Assert.Equal(expected, result);
        }

    }
}
