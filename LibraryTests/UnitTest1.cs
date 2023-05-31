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

    [TestMethod]
    public void TestGetNameProperty()
    {
        Class1 myobject = new Class1();
        Assert.AreEqual(myobject.Name, "no_name");
    }

    [TestMethod]
    public void TestSetNameProperty()
    {
        Class1 myobject = new Class1();
        myobject.Name = "some_name";
        Assert.AreEqual(myobject.Name, "some_name");
    }

    [TestMethod]
    public void TestConverter()
    {
        string hiragana = "ぴかちゅう";
        string? katakana = Converter.Convert(hiragana);
        Assert.AreEqual(katakana, "ピカチュウ");
    }

    [TestMethod]
    public void TestConverterWithNull()
    {
        string? word = null;
        string? katakana = Converter.Convert(word);
        Assert.IsNull(katakana);
    }

    [TestMethod]
    public void TestConverterWithMixedScripts()
    {
        string word = "電はエ。a5２";
        string? converted = Converter.Convert(word);
        Assert.AreEqual(converted, "電ハエ。a5２");
    }

    [TestMethod]
    public void TestSplitter()
    {
        string sentence = "行く川のながれは絶えずして、しかももとの水にあらず。";
        string[] words = Splitter.Split(sentence);
        string[] expected = {"行く", "川", "の", "ながれ", "は", "絶えず", "して", "しかも", "もと", "の", "水", "に", "あらず"};
        CollectionAssert.AreEqual(words, expected);
    }
}