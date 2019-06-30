using System;

public abstract class Writer : IVlogger{

    private string firstName;
    private string lastName;

    public string AuthorBio{
        get{
            return String.Format($"My name is {firstName} {lastName}");
        }
    }

    public Writer(string firstName, string lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public abstract void Vlog();
    

    public abstract void Write(); 
}