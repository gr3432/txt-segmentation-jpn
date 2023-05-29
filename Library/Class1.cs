namespace Library;
public class Class1
{
    public int[] my_numbers;
    public int SIZE = 10;

    public Class1()
    {
        my_numbers = new int[SIZE];
    }
    public Class1(int number)
    {
        my_numbers = Enumerable.Repeat(number, SIZE).ToArray();
    }
    public bool IsIt()
    {
        return true;
    }

}
