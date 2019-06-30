using System;

public abstract class Promoter{

    private string firstName;
    private string lastName;

    private int cellPhone;

    public string MyBuissnesCard{
        get{
            return String.Format($"My name is {firstName} {lastName} and my call phone is {cellPhone}");
        }
    }

    public Promoter(string firstName, string lastName, int cellPhone){
        this.firstName = firstName;
        this.lastName = lastName;
        this.cellPhone = cellPhone;
    }

    public  void Promote(){
        this.ShareWithInnerCircle();
        this.UsePaidAds();
    }

    protected abstract void ShareWithInnerCircle();
    protected abstract void UsePaidAds();
    
}