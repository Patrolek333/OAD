using CharacterSelect.Domain.Character;
using CharacterSelect.Domain.Entity;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Application.Factory;

public static class CharacterFactory
{
    public static Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Warrior => new Warrior(name ?? "Warrior"),
            CharacterClass.Mage    => new Mage(name ?? "Mage"),
            CharacterClass.Rogue   => new Rogue(name ?? "Rogue"),
            CharacterClass.Hivus   => new Hivus(name ?? "Hivus"),
            CharacterClass.Jew   => new Jew(name ?? "Jew"),
            CharacterClass.Redo   => new Redo(name ?? "Redo"),
            _ => throw new ArgumentOutOfRangeException(nameof(cls), "Nieznana klasa postaci.")
        };
    }
}