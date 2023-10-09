using EpicGameSharedServer.Models;
using EpicGameSharedServer.Repositories;
using EpicGameSharedServer.Services;

namespace EpicGame.Services
{
    internal class LocationService : ILocationService
    {
        ILocationRepository repository { get; set; }

        public LocationService(ILocationRepository repository)
        {
            this.repository = repository;
        }

        public LocationService()
        {

        }

        public void Move(IPlayerModel player, int locationId)
        {
            var playerLocation = repository.Get(player.Location.LocationId);

            if (playerLocation.AvailableTransits.Contains(locationId))
            {
                player.Location.LastLocationId = player.Location.LocationId;
                player.Location.LocationId = locationId;
            }
            else
            {
                throw new Exception("Переход невозможен");
            }
        }
    }
}
