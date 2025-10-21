using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Redo : Entity.Character
{
    public Redo(string name) : base(name, CharacterClass.Redo)
    {
        Health = 200;
        Strength = 2;
        Intelligence = 18;
        Agility = 10;
        Charm = 5;
        Sexiness = 13;
        Main_stat = 18;
    }
}