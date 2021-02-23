using System.Linq;
using Xunit;

namespace MaximumPossibleValue
{
    public class SolutionTests
    {
        public Solution _solution;
        public SolutionTests()
        {
            // arrange
            _solution = new Solution();
        }

        [Fact(DisplayName = "Test Case 0")]
        public void MaximumPossibleValue_InputCase0_Returns5268()
        {
            //arrange
            int input = 268;
            int expected = 5268;
            // act
            var result = _solution.MaximumPossibleValue(input);

            // assert
            Assert.Equal(expected, result);

        }

        [Fact(DisplayName = "Test Case 1")]
        public void MaximumPossibleValue_InputCase1_Returns6750()
        {
            //arrange
            int input = 670;
            int expected = 6750;

            // act
            var result = _solution.MaximumPossibleValue(input);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test Case 2")]
        public void MaximumPossibleValue_InputCase2_Returns5999()
        {
            //arrange
            int input = -999;
            int expected = -5999;

            // act
            var result = _solution.MaximumPossibleValue(input);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test Case 3")]
        public void MaximumPossibleValue_InputCase3_Returns50()
        {
            //arrange
            int input = 0;
            int expected = 50;

            // act
            var result = _solution.MaximumPossibleValue(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
