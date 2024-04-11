namespace Rubik.SkillSystem
{
    /// <summary>
    /// 技能释放器
    /// </summary>
    public class SkillDeployer :  IDestroy
    {
        private SkillData m_SkillData = null;

        public SkillDeployer(SkillData skillData)
        {
            m_SkillData = skillData;
            Initialization();
        }
        
        private void Initialization()
        {
            //初始化释放器
        }
        
        public void Destroy()
        {
            //销毁释放器
            
        }
    }
}