using System;

namespace Rubik.SkillSystem
{
    public class SkillImpactAttribute : Attribute
    {
        public SkillImpactType ImpactType { get; private set; }
        public string Description { get; private set; }
        public string TypeName { get; private set; }
        
        public SkillImpactAttribute(SkillImpactType impactType, string description, string typeName)
        {
            ImpactType = impactType;
            Description = description;
            TypeName = typeName;
        }
    }
}