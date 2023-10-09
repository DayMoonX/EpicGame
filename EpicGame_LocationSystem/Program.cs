using EpicGame.Services;
using EpicGameTest;

var service = new LocationService();

var player = Base.GetRandomPlayer();

Console.WriteLine(player.Nickname);