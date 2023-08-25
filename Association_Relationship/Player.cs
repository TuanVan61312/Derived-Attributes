using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Association_Relationship
{
    public class Player
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public Team PlayerTeam { get; set; }
        //public Player Captain { get; set; }

        public Player(int id, string name) 
        {
            Id = id;
            Name = name;
        }
        public void print() 
        {
            Console.WriteLine("Player ID: {0, -4} | Name: {1, -10} | Team: {2, -10}", Id, Name, PlayerTeam.Name);
        }
    }
}