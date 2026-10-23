public abstract class Animal
{
    public string? Name;
    public void SetName(string a)
    {
        Name=a;
    }
    public string GetName()
    {
        return Name;
    }
    public abstract void Eat();
}