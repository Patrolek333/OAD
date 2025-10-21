using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Jew : Entity.Character
{
    public Jew(string name) : base(name, CharacterClass.Jew)
    {
        Health = 80;
        Strength = 9;
        Intelligence = 16;
        Agility = 5;
        Charm = 3;
        Sexiness = 8;
        Main_stat = 16;
    }
}