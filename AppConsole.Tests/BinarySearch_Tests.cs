using System;
using Xunit;

namespace AppConsole.Tests
{
    public class BinarySearch_Tests
    {
        [Theory(DisplayName="Testing Searchs Results")]
        [InlineData(1, (new int[]{1,2,3,4,5}), 0)]
        [InlineData(30, (new int[]{1,5,10,30,45}), 3)]
        [InlineData(80, (new int[]{1,5,10,30,45}), -1)]
        public void TestResults(int target, int[] array, int expectedPosition)
        {
            Assert.Equal(expectedPosition, BinarySearch.Search(target, array));
        }
    }
}
