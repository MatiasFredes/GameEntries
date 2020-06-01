using System;
using Xunit;
using System.Linq;

namespace GameEntries.Tests
{
    public class ArrayExtensionsTests
    {
        [Fact]
        public void AddElementToNullArray_InsertInto_ExceptionExpected()
        {
            //Arrange
            int[] entries = null;
            
            //Assert
            Assert.Throws<ArgumentNullException>(() => entries.InsertInto(element: 10, position: 5));
        }

        [Fact]
        public void AddElementInAPositionGreaterThanTheArray_InsertInto_ExceptionExpected()
        {
            //Arrange
            int[] entries = { 1, 2, 4};

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => entries.InsertInto(element: 10, position: 5));
        }

        [Fact]
        public void AddElementInAValidPosition_InsertInto_AddElement()
        {
            //Arrange
            int[] entries = { 9, 5, 4 };

            //Act
            entries.InsertInto(element: 10, position: 0);
           
            //Arrange
            Assert.Equal(10, entries[0]);
            Assert.Equal(9, entries[1]);
            Assert.Equal(5, entries[2]);
        }

        [Fact]
        public void AddElementInAMidPosition_InsertInto_AddElement()
        {
            //Arrange
            int[] entries = { 9, 7, 4, 3, 2};

            //Act
            entries.InsertInto(element: 5, position: 2);

            //Arrange
            Assert.Equal(9, entries[0]);
            Assert.Equal(7, entries[1]);
            Assert.Equal(5, entries[2]);
            Assert.Equal(4, entries[3]);
            Assert.Equal(3, entries[4]);
        }

        [Fact]
        public void AddElementInLastPosition_InsertInto_AddElement()
        {
            //Arrange
            int[] entries = { 9, 7, 4, 3, 2 };

            //Act
            entries.InsertInto(element: 1, position: 4);

            //Arrange
            Assert.Equal(9, entries[0]);
            Assert.Equal(7, entries[1]);
            Assert.Equal(4, entries[2]);
            Assert.Equal(3, entries[3]);
            Assert.Equal(1, entries[4]);
        }
    }
}
