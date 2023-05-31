namespace Library;

public static class Converter
{
    public static string? Convert(string? word)
    {
        if (word != null)
        {
            string result = "";
            foreach(char c in word)
            {
                if(c >= 'あ' && c <= 'ん')
                {
                    result += (char)(96 + (int)c);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
        return null;

    }
}