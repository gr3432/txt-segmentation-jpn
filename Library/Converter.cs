namespace Library;

public static class Converter
{
    public static string Convert(string word)
    {       
        string result = "";
        foreach(char c in word)
        {
            if(c >= 'あ' && c <= 'ん')
            {
                result += (char)(96 + (int)c);
            }
        }
        return result;
    }
}