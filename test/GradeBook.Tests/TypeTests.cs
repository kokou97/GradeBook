using System;
using Xunit;

namespace GradeBook.Tests;

public class TypeTests
{

    [Fact]
    public void Test1()
    {
        var x = GetInt();
        SetInt(ref x);

        Assert.Equal(42, x);
    }

    private void SetInt(ref int z)
    {
        z = 42;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        string name = "Scott";
        var Uppername = MakeUppercase(name);


        Assert.Equal("Scott", name);
        Assert.Equal("SCOTT", Uppername);
    }

    private string MakeUppercase(string input)
    {
        return input.ToUpper();
    }

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
    public void CanSetNameFromReference()
    {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");
        Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(ref book1, "New Name");
        Assert.Equal("New Name", book1.Name);
    }
    void GetBookSetName(ref Book book, string name)
    {
        book = new Book(name);
    }

    [Fact]
    public void CSharpCanPassByRef_With_Out()
    {
        var book1 = GetBook("Book 1");
        GetBookSetNameOut(out book1, "New Name");
        Assert.Equal("New Name", book1.Name);
    }
    void GetBookSetNameOut(out Book book, string name)
    {
        book = new Book(name);
    }

    [Fact]
    public void CSharpIsPassedByValue()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");
        Assert.Equal("Book 1", book1.Name);
    }
    void GetBookSetName(Book book, string name)
    {
        book = new Book(name);

    }

    void SetName(Book book, string name)
    {
        book.Name = name;
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



    Book GetBook(string name)
    {
        return new Book(name);
    }
}
