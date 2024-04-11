using System;
using System.Collections.Generic;

namespace Rubik.SkillSystem
{
    /// <summary>
    /// 释放器工厂
    /// </summary>
    public class DeployerConfigFactory
    {
        private static Dictionary<int,string> SkillImpactTypeDict = new Dictionary<int, string>();
        
        public static void Init()
        {
            
        }
        
        
        // public static ISkillImpact[] CreateSkillImpacts(List<SkillImpactType> skillImpactTypes)
        // {
        //     List<ISkillImpact> skillImpacts = new List<ISkillImpact>();
        //     foreach (var skillImpactType in skillImpactTypes)
        //     {
        //         ISkillImpact skillImpact = CreateSkillImpact<ISkillImpact>();
        //         skillImpacts.Add(skillImpact);
        //     }
        //     
        // }

        private static T CreateSkillImpact<T>(string typeName) where T : class
        {
            var type = Type.GetType(typeName);
            return Activator.CreateInstance(type) as T;
        }
    }
}