public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        System.Console.WriteLine("I vlog my blog");
    }

    public override void Write()
    {
        System.Console.WriteLine("I write for my blog");
    }
}