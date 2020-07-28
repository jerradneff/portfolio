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
            // A friendly name, because we can't put spaces and other characters in enum names!
            get => ((DescriptionAttribute[])(SkillType.GetType().GetField(SkillType.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false))[0].Description;  
        }
        public float ExpertiseScore { get; set; }
        public int ExperienceYears { get; set; }
    }

    public enum SkillTypeEnum
    {
        // Always include a description for compatibility.
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
