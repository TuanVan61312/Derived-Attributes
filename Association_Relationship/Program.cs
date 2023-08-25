using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Association_Relationship
{
    public class Program
    {
        Console.WriteLine("Hello World!");

            Team t1 = new Team(1, "MU");
            Team t2 = new Team(2, "MC");

            Player p1 = new Player(1, "NV A");
            Player p2 = new Player(2, "NV B");
            Player p3 = new Player(3, "NV C");
            Player p4 = new Player(4, "NV D");
            Player p5 = new Player(5, "NV E");
            Player p6 = new Player(6, "NV F");

            Console.WriteLine(t1.AddPlayer(p1)); //true
            Console.WriteLine(t1.AddPlayer(p2)); //true
            Console.WriteLine(t1.AddPlayer(p1)); //false

            Console.WriteLine(t2.AddPlayer(p3)); //true
            Console.WriteLine(t1.AddPlayer(p3)); //false

            Console.WriteLine("------------------");
            Console.WriteLine(t1.RemovePlayer(p3)); //false
            Console.WriteLine(t2.RemovePlayer(p3)); //true
            Console.WriteLine(t1.AddPlayer(p3)); //true

            Console.WriteLine("------------------");
            t1.Captain = p3;
            t1.Captain = p4;
            t1.Captain = p1;
            t1.print();
    }
}