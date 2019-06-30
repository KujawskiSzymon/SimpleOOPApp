public class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
         System.Console.WriteLine("I vlog my book");
    }

    public override void Write()
    {
        System.Console.WriteLine("I write for my own book");
    }
}