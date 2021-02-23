using System.Linq;
using Xunit;

namespace UniqueIntegers
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
        public void UniqueIntegers_InputCase0_Returns0()
        {
            //arrange
            int input = 4;
            int expected = 0;
            // act
            var result = _solution.UniqueIntegers(input);

            // assert
            Assert.Equal(expected, result.Sum());

        }

        [Fact(DisplayName = "Test Case 1")]
        public void UniqueIntegers_InputCase1_Returns0()
        {
            //arrange
            int input = 3;
            int expected = 0;

            // act
            var result = _solution.UniqueIntegers(input);

            // assert
            Assert.Equal(expected, result.Sum());
        }
    }
}
