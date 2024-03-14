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
            Assert.Equals(4, result); // Последний элемент в массиве - 10, его индекс должен быть 4
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
            Assert.Equals(0, result); // Первый элемент в массиве - 12, его индекс должен быть 0
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
            Assert.Equals(-1, result); // Элемент 7 отсутствует в массиве, ожидаем -1
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
            Assert.Equals(2, result); // Индекс элемента в массиве должен быть 2
        }

    }
}