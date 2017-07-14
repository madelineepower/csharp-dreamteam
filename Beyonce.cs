using System;

public class Beyonce : IDreamTeam
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialty { get; set; }

    public string FullName {get;}

    public void Work()
    {
        Console.WriteLine("The kween is going to werk");
    }

    public Beyonce (string first, string last, string specialty)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Specialty = specialty;
    }
}
