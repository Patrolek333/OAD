using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Charm = 3;
        Sexiness = 9;
        MainStat = this.Agility;
        Atak = MainStat * 3;
        Special = "Ambush";
    }
}