using ConsoleApp1.creatures.characters;
using ConsoleApp1.perks;

namespace ConsoleApp1.items.protection
{

    abstract class Protection : Item
    {
        public String name;
        public int armor;
        public List<Perk> _perks = new List<Perk>();

        public void Apply(Character character)
        {
        }
    }
}