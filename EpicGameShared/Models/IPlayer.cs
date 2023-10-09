namespace EpicGameShared.Models
{
    public interface IPlayer
    {
        /// <summary>
        /// Никнейм игрока
        /// </summary>
        string Nickname { get; set; }

        /// <summary>
        /// Локация игрока
        /// </summary>
        IMover Location { get; set; }
    }
}
