using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Mage : Entity.Character
{
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Charm = 12;
        Sexiness = 3;
        MainStat = this.Intelligence;
        Atak = MainStat * 3;
        Special = "Fireball";
    }
}