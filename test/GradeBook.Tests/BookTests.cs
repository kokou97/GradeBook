using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        //arrage
        var x = 5;
        var y = 2;
        var expected = 10.0;

        //act
        var actual = x * y;

        //assert
        Assert.Equal(expected, actual);
        Assert.True(expected == actual);
    }

    [Fact]
    public void Test2()
    {
        //arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);
        var expectedResult = new Statistics(77.3, 90.5, 85.63333333333333);

        //act
        var actualResult = book.GetStatistics();

        //assert
        Assert.Equal(expectedResult.Low, actualResult.Low, 1);
        Assert.Equal(expectedResult.High, actualResult.High, 1);
        Assert.Equal(expectedResult.Average, actualResult.Average, 1);
    }
}
