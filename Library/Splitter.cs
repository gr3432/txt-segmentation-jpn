using MeCab;

public static class Splitter
{
    public static string[] Split(string sentence)
    {
        var parameter = new MeCabParam();
        var tagger = MeCabTagger.Create(parameter);

        List<string> words = new List<string>();
        foreach (var node in tagger.ParseToNodes(sentence))
        {
            if (node.CharType > 0)
            {
                string[] features = node.Feature.Split(',');
                if ((features[0] == "助詞" && features[1] == "接続助詞") || 
                    (features[0] == "動詞" && features[1] == "接尾") ||
                    (features[0] == "助動詞"))
                {
                    words[^1] += node.Surface;
                }
                else if (features[0] != "記号")
                {
                    words.Add(node.Surface);
                }
            }
        }
        
        return words.ToArray();
    }
}