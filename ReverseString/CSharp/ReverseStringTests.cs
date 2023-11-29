using Xunit;

namespace ReverseString
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
        [InlineData("Try to reverse this string", "gnirts siht esrever ot yrT")]
        [InlineData("A blessing in disguise", "esiugsid ni gnisselb A")]
        [InlineData("Beat around the bush", "hsub eht dnuora taeB")]
        [InlineData("Better late than never", "reven naht etal retteB")]
        public void ReverseString_Result(string input, string expected)
        {
            // act
            var result = _solution.ReverseString(input);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
