using Xunit;
using ProjectClassLibrary1;

namespace TestProjectClassLibrary1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var aClass = new Class1(firstVariable: 2.0, secondVariable: 2.0);
        var result = aClass.Add();

        Assert.Equal(4.0, result);
    }
}