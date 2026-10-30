public class Counter
{
    private int value;
    public Counter(int initialValue)
    {
        value = initialValue;
    }
    public void Decrement()
    {
        if (value > 0)
        {
            value--;
        }
    }
    public void Reset()
    {
        value = 0;
    }
    public void PrintValue()
    {
        Console.WriteLine($"Арзиши ҷорӣ: {value}");
    }
}