using EpicGameShared.Models;
using EpicGameSharedServer.Models;

namespace EpicGame.Models
{
    public class PlayerModel : IPlayerModel
    {
        public string Nickname { get; set; }
        public IMover Location { get; set; }
    }
}
