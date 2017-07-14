using System;
using System.Collections.Generic;

public interface IDreamTeam
{
    string FirstName {get; set;}
    string LastName {get; set;}
    string Specialty {get; set;}

    string FullName {get;}
    void Work();
}

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDreamTeam> ServerSide = new List<IDreamTeam>(){};
            List<IDreamTeam> ClientSide = new List<IDreamTeam>(){};

            Beyonce beyonce = new Beyonce("Beyonce", "Kween", "Being the Kween");
            Daenaryus dany = new Daenaryus("Daenaryus", "Stormborn", "Dragon Riding");
            JonSnow jon = new JonSnow("Jon", "Snow", "Lord Commander");
            Madeline mad = new Madeline("Madeline", "Power", "Making Oven Cookies");
            Jackie jackie = new Jackie("Jackie", "Knight", "Spongebob knowledge");
            Kathy kathy = new Kathy("Kathy", "Weisensel", "Sarcasm");

            ServerSide.Add(beyonce);
            ServerSide.Add(dany);
            ServerSide.Add(jon);
            ClientSide.Add(mad);
            ClientSide.Add(jackie);
            ClientSide.Add(kathy);

            Console.WriteLine("SERVER SIDE");
            foreach (IDreamTeam person in ServerSide)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("CLIENT SIDE");
            foreach (IDreamTeam person in ClientSide)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("NOW LETS WERRRRRKKKKKKK");
            foreach (IDreamTeam person in ServerSide)
            {
                person.Work();
            }
             foreach (IDreamTeam person in ClientSide)
            {
                person.Work();
            }
    }

}

}
