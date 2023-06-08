using Library;

namespace LibraryTests;

[TestClass]
public class UnitTest1
{
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

    public static IEnumerable<object[]> GetSplitterData()
    {
        yield return new object[] {
            "行く川のながれは絶えずして、しかももとの水にあらず。",
            new string[] {"行く", "川", "の", "ながれ", "は", "絶えず", "して", "しかも", "もと", "の", "水", "に", "あらず"}
        };
        yield return new object[] {
            "食べさせられない",
            new string[] {"食べさせられない"}
        };
        yield return new object[] {
            "説明してください",
            new string[] {"説明", "して", "ください"}
        };
    }

    [TestMethod]
    [DynamicData(nameof(GetSplitterData), DynamicDataSourceType.Method)]
    public void TestSplitter(string sentence, string[] expected)
    {
        string[] words = Splitter.Split(sentence);
        CollectionAssert.AreEqual(words, expected);
    }
}