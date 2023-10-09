using EpicGameSharedServer.Models;

namespace EpicGameSharedServer.Repositories
{
    public interface IItemRepository
    {
        IItemModel Get(int id);
    }
}
