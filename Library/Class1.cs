namespace Library;
public class Class1
{
    public int[] my_numbers;

    public Class1()
    {
        my_numbers = new int[10];
    }
    public Class1(int number)
    {
        my_numbers = Enumerable.Repeat(number, 10).ToArray();
    }
    public bool IsIt()
    {
        return true;
    }

}
