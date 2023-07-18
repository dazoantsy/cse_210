using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("120 102nd Avenue", "Fort St John", "British Columbia", "V1J 3Y7", "Canada");
        addresses[1] = new Address("1138 rue St-Paul", "Sorel", "Quebec", "J3P 4M9", "Canada");
        addresses[2] = new Address("Rua Nelson Lemos de Carvalho 592", "Belo Horizonte", "Minas Gerais", "31160-590", "Brazil");

        Event[] events =  new Event[3];
        events[0] = new Lectures("Initiation en informatique", "Learn the basics of computing, in French", "07/26/2023", "10:00am", addresses[0], "Mary", "180 People");
        events[1] = new Receptions("Simon's Baptism", "Simon's 8th birthday party after his baptism at the chappel", "01/05/2024", "02:00pm", addresses[1], "bodin82971@sparkroi.com");
        events[2] = new Outdoor("Picnic With Family", "Enjoy spending time with family at River Lake", "11/12/2023", "08:00am", addresses[2], "Sunny");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Event N°: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());
            
        }
    }
}