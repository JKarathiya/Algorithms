using Xunit;
using System.Collections.Generic;

namespace RiverRecords
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
        public void RiverRecords_InputCase_Returns8()
        {
            //arrange
            var input = new List<int>() { 2, 3, 10, 2, 4, 8, 1 };
            // act
            var result = _solution.maxTrailing(input);

            // assert
            Assert.Equal(8, result);
        }

        [Fact(DisplayName = "Test Case 1")]
        public void RiverRecords_InputCase_Returns2()
        {
            //arrange
            var input = new List<int>() { 7, 9, 5, 6, 3, 2 };
            // act
            var result = _solution.maxTrailing(input);

            // assert
            Assert.Equal(2, result);
        }
    }
}
