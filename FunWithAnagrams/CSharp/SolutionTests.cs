using System.Collections.Generic;
using Xunit;

namespace FunWithAnagrams
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
        public void FunWithAnagrams_StringArray_ReturnExpectedResult()
        {
            //arrange
            List<string> input = new List<string>() { "code", "doce", "ecod", "framer", "frame" };
            List<string> expected = new List<string>() { "code", "frame", "framer" };

            // act
            var result = _solution.FunWithAnagrams(input);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Test Case 1")]
        public void FunWithAnagrams_SecondStringArray_ReturnExpectedResult()
        {
            //arrange
            List<string> input = new List<string>() { "code", "aaagmnrs", "anagrams", "doce" };
            List<string> expected = new List<string>() { "aaagmnrs", "code" };

            // act
            var result = _solution.FunWithAnagrams(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
