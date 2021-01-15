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

        [InlineData("Bat")]
        [InlineData("decriminalisation")]
        [Theory(DisplayName = "Check that a short rollercoaster word returns true.")]
        public void RollercoasterWord_RollerCoasterWord_ReturnsTrue(string input)
        {
            // act
            var result = _solution.RollercoasterWord(input);

            // assert
            Assert.True(result, "short rollercoaster word should returns true.");
        }
        [Fact(DisplayName = "Check that a short non-rollercoaster word returns false.")]
        public void RollercoasterWord_NonRollerCoasterWord_ReturnsFalse()
        {
            // act
            var result = _solution.RollercoasterWord("Bet");

            // assert
            Assert.False(result);
        }
        [Fact(DisplayName = "Check that a string containing a single letter returns true")]
        public void RollercoasterWord_SingleLetterString_ReturnsTrue()
        {
            // act
            var result = _solution.RollercoasterWord("a");

            // assert
            Assert.True(result);
        }
        [Fact(DisplayName = "Check that a two letter string returns true")]
        public void RollercoasterWord_TwoLetterString_ReturnsTrue()
        {
            // act
            var result = _solution.RollercoasterWord("Ba");
            // assert
            Assert.True(result);
        }
        [Fact(DisplayName = "Check that a string containing two of the same letter in succession returns false")]
        public void RollercoasterWord_TwoOfSameLetter_ReturnsFalse()
        {
            // act
            var result = _solution.RollercoasterWord("succession");

            // assert
            Assert.False(result);
        }
    }
}
