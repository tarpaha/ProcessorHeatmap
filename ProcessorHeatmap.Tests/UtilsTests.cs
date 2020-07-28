using NUnit.Framework;

namespace ProcessorHeatmap.Tests
{
    public class UtilsTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 1)]
        [TestCase(3, 3, 1)]
        [TestCase(4, 2, 2)]
        public void CalculateDimensionsTests(int cellsCount, int cols, int rows)
        {
            Assert.That(Utils.CalculateDimensions(cellsCount), Is.EqualTo((cols, rows)));
        }
    }
}