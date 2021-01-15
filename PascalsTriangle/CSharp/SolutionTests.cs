using Xunit;

namespace PascalsTriangle
{
    public class SolutionTests
    {
        Solution _solution;
        public SolutionTests()
        {
            _solution = new Solution();
        }

        [Fact(DisplayName = "Ensure the solution can handle the invalid input -1.")]
        public void CalculatePascalLayerTotal_InvalidLayerNegative1_ReturnsNegative1()
        {
            Assert.Equal(-1, _solution.CalculatePascalLayerTotal(-5));
        }

        [Fact(DisplayName = "Calculate the total for layer 0.")]
        public void CalculatePascalLayerTotal_Layer0_Returns1()
        {
            Assert.Equal(1, _solution.CalculatePascalLayerTotal(0));
        }

        [Fact(DisplayName = "Calculate the total for layer 1.")]
        public void CalculatePascalLayerTotal_Layer1_Returns2()
        {
            Assert.Equal(2, _solution.CalculatePascalLayerTotal(1));
        }

        [Fact(DisplayName = "Calculate the total for layer 3.")]
        public void CalculatePascalLayerTotal_Layer3_Returns8()
        {
            Assert.Equal(8, _solution.CalculatePascalLayerTotal(3));
        }

        [Fact(DisplayName = "Calculate the total for layer 5.")]
        public void CalculatePascalLayerTotal_Layer5_Returns32()
        {
            Assert.Equal(32, _solution.CalculatePascalLayerTotal(5));
        }

        [Fact(DisplayName = "Calculate the total for layer 7.")]
        public void CalculatePascalLayerTotal_Layer7_Returns128()
        {
            Assert.Equal(128, _solution.CalculatePascalLayerTotal(7));
        }

        [Fact(DisplayName = "Calculate the total for a large layer (20).")]
        public void CalculatePascalLayerTotal_LargeLayer20_Returns8()
        {
            Assert.Equal(1048576, _solution.CalculatePascalLayerTotal(20));
        }


        [Fact(DisplayName = "Calculate the total for a very large layer (30).")]
        public void CalculatePascalLayerTotal_VeryLarge_Layer30_Returns8()
        {
            Assert.Equal(1073741824, _solution.CalculatePascalLayerTotal(30));
        }

        [Fact(DisplayName = "Ensure -1 is returned when the layer total exceeds the maximum integer size.")]
        public void CalculatePascalLayerTotal_Layer33_ReturnsNegative1()
        {
            Assert.Equal(-1, _solution.CalculatePascalLayerTotal(33));
        }
    }
}
