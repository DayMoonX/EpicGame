namespace EpicGameShared.Models
{
    public interface IBattle
    {
        long Id { get; set; }

        IFighter[] Fighters { get; set; }

        bool? SideWin { get; set; }
    }

 
    public interface IFighter : IDamager, IBattleStats
    {
        int Id { get; set; }
        bool Side { get; set; }
    }


    public interface IBattleStats
    {
        int TitalDamageMob { get; set; }
        int TotalDamage { get; set; }
        int TotalHeal { get; set; }
    }

    public interface IDamager
    {
        int Health { get; set; }

        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        int NextDamage { get; set; }

        int Protection { get; set; }
        int Agility { get; set; }
        int Intuition { get; set; }
        int Power { get; set; }
    }


}
