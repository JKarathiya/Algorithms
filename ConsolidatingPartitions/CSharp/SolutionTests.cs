using System.Collections.Generic;
using Xunit;

namespace ConsolidatingPartitions
{
    public class SolutionTests
    {
        public Solution _solution;
        public SolutionTests()
        {
            // arrange
            _solution = new Solution();
        }

        [Fact]
        public void MinPartitions_FirstInput_ReturnResults()
        {
            //arrange
            List<int> used = new List<int>() { 3, 2, 1, 3, 1 };
            List<int> totalCapacity = new List<int>() { 3, 5, 3, 5, 5 };
            int expected = 2;

            // act
            var result = _solution.minPartitions(used, totalCapacity);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MinPartitions_SecondInput_ReturnResults()
        {
            //arrange
            List<int> used = new List<int>() { 3, 3, 3 };
            List<int> totalCapacity = new List<int>() { 5, 5, 5 };
            int expected = 3;

            // act
            var result = _solution.minPartitions(used, totalCapacity);

            // assert
            Assert.Equal(expected, result);
        }

    }
}
