using System;

namespace Rubik.SkillSystem
{
    [Flags]
    public enum CampType
    {
        PLAYER = 1 << 0,
        ENEMY = 1 << 1,
        NEUTRAL = 1 << 2,
    }
}