namespace EpicGameShared.Models
{
    public interface ILocation
    {
        /// <summary>
        /// Id локации
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Доступные переходы
        /// </summary>
        int[] AvailableTransits { get; set; }
    }

    public interface IMover
    {
        /// <summary>
        /// Текущая локация
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Id последней локации
        /// </summary>
        public int LastLocationId { get; set; }

        /// <summary>
        /// Время следующего перехода
        /// </summary>
        public DateTime NextTransit { get; set; }
    }
}
