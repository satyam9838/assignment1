using LinkedLists_assignment;

namespace LinkedLists_assignment.Tests;
public class UnitTest1
{
    [Fact]
    public void AddLast_ShouldAddNodeIfListIsEmpty()
    {
        //Arrange - [Setup]
        LinkedList<int> lists = new LinkedList<int>();

        //Act 
        lists.AddLast(1);

        //Assert
        Assert.Equal(1, lists.GetLength());
    }

    [Fact]
    public void AddLast_ShouldAddNodeAtLastToLinkedList()
    {
        //Arrange - [Setup]
        LinkedList<int> lists = new LinkedList<int>();
        lists.AddLast(1);

        //Act
        lists.AddLast(2);

        //Assert
        Assert.Equal(2, lists.GetLength());
    }

    [Fact]
    public void AddFirst_ShouldAddNodeAtBeginning()
    {
        //Arrange
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(2);
        list.AddLast(3);

        //Act
        list.AddFirst(1);

        //Assert
        Assert.Equal(0, list.FirstIndexOf(1));
    }

    [Fact]
    public void Clear_ShouldDeleteAllItems()
    {
        // Arrange
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        // Act
        list.Clear();

        // Assert
        Assert.Equal(0, list.GetLength());
    }

    [Fact]
    public void RemoveLast_ShouldDeleteLastItem()
    {
        //Arrange
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);

        //Act
        list.RemoveLast();

        //Assert
        Assert.Equal(2,list.GetLength());
        Assert.Equal(-1, list.FirstIndexOf(4));
        //list.getlength or indexof
    }

    [Fact]
    public void RemoveLast_ShouldEmptyListIfListContainsOnlyOneItem()
    {
        //Arrange
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);

        //Act
        list.RemoveLast();

        //Assert
        Assert.Equal(0, list.GetLength());

    }

    [Fact]
    public void RemoveLast_ShouldThrowExceptionWhenListisAlreadyEmpty()
    {
        //Arrange
        LinkedList<int> list = new LinkedList<int>();

        //Act
        list.RemoveLast();

        //Assert
        Assert.Fail("List is Empty!");
    }
}
