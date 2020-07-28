using System.ComponentModel;
using System;

namespace portfolio.Models
{
    public class Skill
    {
        public string SkillName { get; set; }
        public SkillTypeEnum SkillType { get; set; }
        public string SkillTypeName
        {
            // A friendly name, because we can't put spaces in enum names!
            get => Enum.GetName(typeof(SkillTypeEnum), SkillType);
        }
        public float ExpertiseScore { get; set; }
        public int ExperienceYears { get; set; }
    }

    public enum SkillTypeEnum
    {
        [Description("Development Fundamentals")]
        DevelopmentFundamentals,
        [Description("Database")]
        Database,
        [Description("Back-end Development")]
        BackendDevelopment,
        [Description("Front-end Development")]
        FrontendDevelopment,
        [Description("Languages")]
        Languages
    }
}
