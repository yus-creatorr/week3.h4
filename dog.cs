public class Dog
{
    private string name;
    private string breed;
    private int age;

    public Dog(string name, string breed, int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ном: {name}, Зот: {breed}, Синну сол: {age} сола");
    }
}