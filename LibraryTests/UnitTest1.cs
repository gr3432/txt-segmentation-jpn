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

    [TestMethod]
    public void TestMethod2()
    {
        Class1 myobject = new Class1(5);
        for (int i = 0; i < Class1.SIZE; i++)
        {
            Assert.AreEqual(myobject.my_numbers[i], 5);
        }
    }
}