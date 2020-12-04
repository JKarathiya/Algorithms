using Xunit;

namespace RollercoasterWord
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            Assert.False(solution.RollercoasterWord("Bat"));
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            Assert.False(solution.RollercoasterWord("Bet"));
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            Assert.True(solution.RollercoasterWord("decriminalisation"));
        }
    }
}
