// See https://aka.ms/new-console-template for more information
using jurnalmod6_103022300065;
using System;



class program
{
    static void Main(string[] args)
    {
        
        SayaTuberUser user1 = new SayaTuberUser("ojan");
        SayaTubeVideo v1 = new SayaTubeVideo("one piece");
        SayaTubeVideo v2 = new SayaTubeVideo("ultraman");
        SayaTubeVideo v3 = new SayaTubeVideo("si budi");
        SayaTubeVideo v4 = new SayaTubeVideo("pelangi");
        SayaTubeVideo v5 = new SayaTubeVideo("Batu");
        SayaTubeVideo v6 = new SayaTubeVideo("Rumput");
        SayaTubeVideo v7 = new SayaTubeVideo("Kaca");
        SayaTubeVideo v8 = new SayaTubeVideo("Matahari");
        SayaTubeVideo v9= new SayaTubeVideo("Black CLover");
        SayaTubeVideo v10 = new SayaTubeVideo("Interstellar");

        Random rand = new Random();
        v1.IncreasePlayCount();
        v2.IncreasePlayCount();
        v3.IncreasePlayCount();
        v4.IncreasePlayCount();
        v5.IncreasePlayCount();
        v6.IncreasePlayCount();
        v7.IncreasePlayCount();
        v8.IncreasePlayCount();
        v9.IncreasePlayCount();
        v10.IncreasePlayCount();
        v10.IncreasePlayCount();
        v1.IncreasePlayCount();
        //v1.IncreasePlayCount(rand.Next(10000, 99999));
        //v2.IncreasePlayCount(rand.Next(10000, 99999));
        //v3.IncreasePlayCount(rand.Next(10000, 99999));
        //v4.IncreasePlayCount(rand.Next(10000, 99999));
        //v5.IncreasePlayCount(rand.Next(10000, 99999));
        //v6.IncreasePlayCount(rand.Next(10000, 99999));
        //v7.IncreasePlayCount(rand.Next(10000, 99999));
        //v8.IncreasePlayCount(rand.Next(10000, 99999));
        //v9.IncreasePlayCount(rand.Next(10000, 99999));
        //v10.IncreasePlayCount(rand.Next(10000, 99999));

        user1.AddVideo(v1);
        user1.AddVideo(v2);
        user1.AddVideo(v3);
        user1.AddVideo(v4);
        user1.AddVideo(v5);
        user1.AddVideo(v6);
        user1.AddVideo(v7);
        user1.AddVideo(v8);
        user1.AddVideo(v9);
        user1.AddVideo(v10);

        Console.WriteLine("Review Film " + v1.Gettitle() + "oleh ojan");
        v1.PrintVideoDetails();
        Console.WriteLine("Review Film " + v2.Gettitle() + "oleh ojan");
        v2.PrintVideoDetails();
        Console.WriteLine("Review Film " + v3.Gettitle() + "oleh ojan");
        v3.PrintVideoDetails();
        Console.WriteLine("Review Film " + v4.Gettitle() + "oleh ojan");
        v4.PrintVideoDetails();
        Console.WriteLine("Review Film " + v5.Gettitle() + "oleh ojan");
        v5.PrintVideoDetails();
        Console.WriteLine("Review Film " + v6.Gettitle() + "oleh ojan");
        v6.PrintVideoDetails();
        Console.WriteLine("Review Film " + v7.Gettitle() + "oleh ojan");
        v7.PrintVideoDetails();
        Console.WriteLine("Review Film " + v8.Gettitle() + "oleh ojan");
        v8.PrintVideoDetails();
        Console.WriteLine("Review Film " + v9.Gettitle() + "oleh ojan");
        v9.PrintVideoDetails();
        Console.WriteLine("Review Film " + v10.Gettitle() + "oleh ojan");
        v10.PrintVideoDetails();



    }
}
