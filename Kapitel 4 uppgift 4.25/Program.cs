using System;
namespace uppgift425
{
    class program
    {
        static void Main(string[]args)
        {
            bool end=true;
            while (end)
            {
                Console.WriteLine("Välj en av dem här tre alternativen\n1.subtrahera ett tal med ett annat\n2.dividera ett tal med ett annat\n3.Avsluta programmet");
                int n1 = int.Parse(Console.ReadLine());
                switch (n1)
                {
                    case 1:
                        Console.WriteLine("Skriv två tal efter varandra");
                        int n2 = int.Parse(Console.ReadLine());
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(n2 - n3);
                        break;

                    case 2:
                        Console.WriteLine("Skriv två tal efter varandra");
                        float n4 = int.Parse(Console.ReadLine());
                        float n5 = int.Parse(Console.ReadLine());
                        Console.WriteLine(n4/n5);
                        break;

                    case 3:
                        end = false;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}