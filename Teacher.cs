public class Teacher : Person
{
    public Teacher()
    {
    }

    public Teacher(string a) : base(a)
    {
    }

    public void Explain()
    {
        System.Console.WriteLine("The teacher is explaining");
    }
}