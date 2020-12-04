using Xunit;

namespace PascalsTriangle
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            Assert.Equal(1, solution.CalculatePascalLayerTotal(0));
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            Assert.Equal(2, solution.CalculatePascalLayerTotal(1));
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            Assert.Equal(32, solution.CalculatePascalLayerTotal(5));
        }
    }
}
