using GraphQL_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_01.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        // later code will be updated
        // to get data from database
        public List<Player> GetAll()
        {
            return new List<Player>
            {
                new Player
                {
                    Id=1,
                    FirstName= "Rohit",
                    LastName = "Sharma",
                    CurrentAge = 32,
                    PlayingRole = "Opener",
                    BattingStyle = "Right-hand Bat",
                    BowlingStyle="spin",
                    Teams="India, Mumbai, Mumbai Indians"
                }
    // display purpose items hidden , while testing add more items
            };
        }
    }
}
