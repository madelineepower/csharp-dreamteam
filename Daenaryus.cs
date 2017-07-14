using System;
public class Daenaryus : IDreamTeam
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialty { get; set; }

    public string FullName {get;}

    public void Work()
    {
        Console.WriteLine("Daenaryus is being a badass B and riding her dragons and shit");
    }

    public Daenaryus (string first, string last, string specialty)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Specialty = specialty;
    }
} 
