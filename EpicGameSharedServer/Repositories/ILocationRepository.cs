using EpicGameSharedServer.Models;

namespace EpicGameSharedServer.Repositories
{
    public interface ILocationRepository
    {
        ILocationModel Get(int id);
    }
}
