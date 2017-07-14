using System;
public class Kathy : IDreamTeam
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialty { get; set; }

    public string FullName {get;}

    public void Work()
    {
        Console.WriteLine("Kathy is stealing dogs");
    }

    public Kathy (string first, string last, string specialty)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Specialty = specialty;
    }
}
