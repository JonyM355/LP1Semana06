using System;

namespace MyRoguelike
{
    [Flags]
    public enum Toughness
    {
        VeryEasy = 1 << 0,
        Easy = 1 << 1,
        Normal = 1 << 2,
        Tough = 1 << 3,
        Nightmare = 1 <<4
    }
}