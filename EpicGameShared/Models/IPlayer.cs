namespace EpicGameShared.Models
{
    public interface IPlayer
    {
        string Nickname { get; set; }

        IMover Location { get; set; }

        IPlayerItem[] Inventory { get; set; }
    }

    public interface IPlayerItem
    {
        long Id { get; set; }

        int ItemId { get; set; }
        string Owner { get; set; }

        int Count { get; set; }
    }
}
