public class Photo:Publication
{
    public override void Public()
    {
        System.Console.WriteLine("Photo published");
    }

    public virtual void Display()
    {
        System.Console.WriteLine("Photo publicated");
    }
}