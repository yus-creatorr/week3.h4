public class Student : Person
{
    public Student()
    {
    }

    public Student(string a) : base(a)
    {
    }

    public void Study()
    {
        System.Console.WriteLine("The Student is studying");
    }
}