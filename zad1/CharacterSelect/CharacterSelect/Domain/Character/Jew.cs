using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Jew : Entity.Character
{
    public Jew(string name) : base(name, CharacterClass.Jew)
    {
        Health = 80;
        Strength = 9;
        Intelligence = 10;
        Agility = 8;
        Charm = 15;
        Sexiness = 6;
        MainStat = this.Charm;
        Atak = MainStat * 3;
        Special = "Promised Land";
    }
}