using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var avgTst = book.AverageGrade();
            var highestTst = book.HighestGrade();
            var lowestTst = book.LowestGrade();

            Assert.Equal(85.63,avgTst,2); // el tercer parametro indica el nivel de presicion para que pase el test
            Assert.Equal(90.5,highestTst);
            Assert.Equal(77.3,lowestTst);
      
        }
    }
}
