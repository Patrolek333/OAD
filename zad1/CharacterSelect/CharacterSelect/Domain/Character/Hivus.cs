using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Hivus : Entity.Character
{
    public Hivus(string name) : base(name, CharacterClass.Hivus)
    {
        Health = 1;
        Strength = 27;
        Intelligence = 1;
        Agility = 14;
        Charm = 99;
        Sexiness = 99;
        Main_stat = 99;
    }
}