using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            ListHumans listHumans = new ListHumans();
            listHumans[0] = new Man();
            listHumans[0].Age = 20;
            listHumans[0].Name = "Alesha";
            Console.WriteLine(listHumans[0]);

            listHumans[1] = new Worker();
            listHumans[1].Age = 21;
            listHumans[1].Name = "Bob";
            Console.WriteLine(listHumans[1]);

            listHumans[2] = new Teenager();
            listHumans[2].Age = 15;
            listHumans[2].Name = "Jastin";
            Console.WriteLine(listHumans[2]);
        }
    }
}
