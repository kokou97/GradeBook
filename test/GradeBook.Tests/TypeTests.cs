using System;
using Xunit;

namespace GradeBook.Tests;

public class TypeTests
{
    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        //arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        //assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);

    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        //arrange
        var book1 = GetBook("Book 1");
        var book2 = book1;

        //assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 1", book2.Name);
        SetName(book1, "Book 1 new");

        Assert.Equal("Book 1 new", book2.Name);
        SetName(book2, "Book 2 new");
        Assert.Equal("Book 2 new", book1.Name);
        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1, book2));

    }

    void SetName(Book book, string name)
    {
        book.Name = name;
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}
