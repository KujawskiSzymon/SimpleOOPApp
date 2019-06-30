public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, int cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        System.Console.WriteLine("I share with my friends");
    }

    protected override void UsePaidAds()
    {
        System.Console.WriteLine("I use google ads");
    }
}