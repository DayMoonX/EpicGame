using EpicGameSharedServer.Models;

namespace EpicGameSharedServer.Repositories
{
    internal interface IPlayerRepository
    {
        IPlayerModel Get(string nickname);
    }
}
