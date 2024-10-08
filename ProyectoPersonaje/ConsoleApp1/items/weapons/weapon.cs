using ConsoleApp1.creatures.characters;
using ConsoleApp1.perks;

namespace ConsoleApp1.items.weapons
{
    abstract class Weapon : Item
    {
        public String name;
        public int damage;
        public List<Perk> _perks = new List<Perk>();

        public void Apply(Character character)
        {
        }
    }
}