using NUnit.Framework;

namespace ProcessorHeatmap.Tests
{
    public class MainWindowTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 1)]
        [TestCase(3, 3, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(5, 5, 1)]
        [TestCase(6, 3, 2)]
        [TestCase(7, 7, 1)]
        [TestCase(8, 4, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(10, 5, 2)]
        [TestCase(11, 11, 1)]
        [TestCase(12, 4, 3)]
        [TestCase(13, 13, 1)]
        [TestCase(14, 7, 2)]
        [TestCase(15, 5, 3)]
        [TestCase(16, 4, 4)]
        [TestCase(17, 17, 1)]
        [TestCase(18, 6, 3)]
        [TestCase(19, 19, 1)]
        [TestCase(20, 5, 4)]
        [TestCase(21, 7, 3)]
        [TestCase(22, 11, 2)]
        [TestCase(23, 23, 1)]
        [TestCase(24, 6, 4)]
        [TestCase(25, 5, 5)]
        [TestCase(26, 13, 2)]
        [TestCase(27, 9, 3)]
        [TestCase(28, 7, 4)]
        [TestCase(29, 29, 1)]
        [TestCase(30, 6, 5)]
        [TestCase(31, 31, 1)]
        [TestCase(32, 8, 4)]
        [TestCase(128, 16, 8)]
        [TestCase(256, 16, 16)]
        public void CalculateDimensionsTests(int cellsCount, int cols, int rows)
        {
            Assert.That(MainWindow.CalculateDimensions(cellsCount), Is.EqualTo((cols, rows)));
        }
    }
}