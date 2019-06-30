public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, int cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        System.Console.WriteLine("I share with my ig followers");
    }

    protected override void UsePaidAds()
    {
        System.Console.WriteLine("I use Facebook ads");
    }
    

    

    public void Vlog()
    {
        System.Console.WriteLine("Już nie wiem co wymyślać");
    }

    public void Workout()
    {
        System.Console.WriteLine("I workout just like club promoters does");
    }

    
}