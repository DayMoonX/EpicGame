using EpicGameSharedServer.Models;
using RestSharp;

namespace EpicGameTest
{
    public static class Base
    {
        static readonly RestClient Rest = new(new RestClientOptions("https://localhost:7040/Api"));

        public static IPlayerModel GetRandomPlayer()
        {
            return Rest.GetJson<IPlayerModel>("RandomPlayer");
        }

        public static ILocationModel[] GetRandomLocations()
        {
            return Rest.GetJson<ILocationModel[]>("RandomLocations");
        }
    }
}

