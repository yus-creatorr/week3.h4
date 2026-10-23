public class Person
{
    string? name;
    public Person(){}
    public Person(string a)
    {
        name=a;
    }
    public virtual string Tostring()
    {
        return "!";
    }
}