using System;
public class JonSnow : IDreamTeam
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialty { get; set; }

    public string FullName {get;}

    public void Work()
    {
        Console.WriteLine("Jon Snow is coming back from the dead");
    }

    public JonSnow (string first, string last, string specialty)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Specialty = specialty;
    }
}
