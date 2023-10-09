using EpicGameSharedServer.Models;

namespace EpicGameSharedServer.Services
{
    public interface ILocationService
    {
        void Move(IPlayerModel player, int locationId);
    }
}
