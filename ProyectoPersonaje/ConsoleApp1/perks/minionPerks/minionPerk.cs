using ConsoleApp1.creatures;
using ConsoleApp1.creatures.minions;

namespace ConsoleApp1.perks.minionPerks
{

    public class MinionPerk : Perk
    {
        public String name { get; set; }
        public List<Minion> _minions = new List<Minion>();

        public void Apply(Creature creature)
        {
        }
    }
}