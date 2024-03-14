using NUnit.Framework;

namespace BinarySearch.Tests
{
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearch_SearchLastElement_ReturnsLastIndex()
        {
            // Arrange
            int[] array = { 2, 4, 6, 8, 10 };
            int element = 10;

            // Act
            int result = BinarySearch.Search(array, element);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
    
        [Test]
        public void BinarySearch_SearchFirstElement_ReturnsIndexZero()
        {
            // Arrange
            int[] array = { 12, 15, 18, 21, 24 };
            int element = 12;

            // Act
            int result = BinarySearch.Search(array, element);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void BinarySearch_ElementDoesNotExist_ReturnsNegativeOne()
        {
            // Arrange
            int[] array = { 2, 4, 6, 8, 10 };
            int element = 7;

            // Act
            int result = BinarySearch.Search(array, element);

            // Assert
            Assert.That(result, Is.Negative);
        }

        [Test]
        public void BinarySearch_ElementExists_ReturnsIndex()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int element = 5;

            // Act
            int result = BinarySearch.Search(array, element);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}