using System;

namespace MyGame
{
    [Flags]
    public enum PowerUp
    {
        Health = 1 << 0,
        Shield = 1 << 1
    }
}