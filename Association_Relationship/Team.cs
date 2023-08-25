using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Association_Relationship
{
    public class Team
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        private List<Player> members = new List<Player>();
        private const int MAX_PLAYER = 11;
        private Player captain;
        public Player Captain 
        {
            get { return captain; }
            set 
            {
                if(value.PlayerTeam == this) 
                {
                    captain = value;
                    //if(captain == null) 
                    //{
                    //    captain = value;
                    //}
                    //else 
                    //{
                        
                    //}
                }
                //captain = value; 
            }
        }

        public Team(int id, string name) 
        {
            Id = id;
            Name = name;
            members = new List<Player>();
        }

        public bool AddPlayer(Player p) 
        {
            if (members.Count < MAX_PLAYER && p.PlayerTeam == null)                
            {
                //What if the player 'p' is currently playing for another team
                members.Add(p);
                p.PlayerTeam = this;
                return true;
            }
            return false;
        }

        public bool RemovePlayer(Player p)
        {
            if (members.Count > 0 && p.PlayerTeam == this)
            {
                members.Remove(p);
                p.PlayerTeam = null;
                return true;
            }
            return false;
        }

        public void print() 
        {
            Console.WriteLine("Team ID: {0, -4} | Name: {1, -20}", Id, Name);
            if(captain != null)
                Console.WriteLine("Current captain is: " + Captain.Name);
            Console.WriteLine("There are {0} players in the team", members.Count);
            foreach(Player p in members) 
            {
                Console.Write("\t");
                p.print();
            }
        }
    }
}