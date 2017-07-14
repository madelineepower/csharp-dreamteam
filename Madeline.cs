using System;

public class Madeline : IDreamTeam
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialty { get; set; }

    public string FullName {get;}

    public void Work()
    {
        Console.WriteLine("Madeline is WERKING");
    }

    public Madeline (string first, string last, string specialty)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Specialty = specialty;
    }
}
