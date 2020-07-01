using GraphQL_01.Models;
using System.Collections.Generic;

namespace GraphQL_01.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAll();
    }
}
