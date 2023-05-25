using Library;

namespace LibraryTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Class1 myobject = new Class1();
        Assert.IsTrue(myobject.IsIt());
    }
}