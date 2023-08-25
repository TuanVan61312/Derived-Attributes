using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derived
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("TV", new Address(23, "Le Van Luong", "Hanoi"), new DateTime(2000, 12, 10), 1);
            Console.WriteLine(p1.Age);
            //Console.WriteLine(p1.Age + " | " + p1.PRole); 
            p1.Birthdate = new DateTime(2000, 4, 12);
            Console.WriteLine(p1.Age);
            //p1.PRole = Role.MANAGER;
            //Console.WriteLine(p1.Age + " | " + p1.PRole);
            Person p2 = new Person("TV 123", new Address(23, "Le Van Luong", "Hanoi"), new DateTime(2000, 12, 10), 2);
            Person p3 = new Person("TV 456", new Address(23, "Le Van Luong", "Hanoi"), new DateTime(2000, 12, 10), 3);
            p2.Manager = p1;
            p3.Manager = p1;
        }
    }
}