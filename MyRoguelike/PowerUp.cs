using System;

namespace MyRoguelike
{
    [Flags]
    public enum PowerUp
    {
        Health = 1 << 0,
        Shield = 1 << 1
    }
}