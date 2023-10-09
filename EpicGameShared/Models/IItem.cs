namespace EpicGameShared.Models
{
    public interface IItem
    {
        int Id { get; set; }

        string Name { get; set; }
        int Level { get; set; }

        Rarity Rarity { get; set; }

        DateTime? LifeTime { get; set; }
    }

    public enum Rarity
    {
        Gray,
        Green,
        Blue,
        Purple,
        Red,
        Orange
    }
}
