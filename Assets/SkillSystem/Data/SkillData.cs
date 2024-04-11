using System;

namespace Rubik.SkillSystem
{
    [Serializable]
    public class SkillData
    {
        public int SkillID; //技能ID
        public string SkillName; //技能名称
        public string SkillDes; //技能描述
        public string SkillIcon; //技能图标
        public int SkillLevel; //技能等级
        public float SkillTime; //技能冷却时间
        public float SkillRemainTime; //技能剩余时间
        public float SkillDistance; //技能施放距离
        public float SkillDuration; //技能持续时间
        public float SkillInterval; //技能间隔时间
        public float SkillValueRatio; //技能数值比例
        public SkillCostType SkillCostType; //技能消耗类型
        public int SkillCost; //技能消耗
        public CampType TargetTag; //目标标签
        public SkillAttackType SkillAttackType; //技能攻击类型
        public SkillSelectorType SkillSelectorType; //技能选择类型
    }
}