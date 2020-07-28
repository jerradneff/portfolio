using portfolio.Models;
using System.Collections.Generic;

namespace portfolio.Data
{
    public class SkillsRepoStatic : ISkillsRepo
    {
        public IEnumerable<Skill> GetSkills()
        {
            return new List<Skill>
            {
                new Skill { 
                    SkillName = "Object-oriented programming",
                    SkillType = SkillTypeEnum.DevelopmentFundamentals,
                    ExpertiseScore = 1.0F,
                    ExperienceYears = 15
                },
                new Skill {
                    SkillName = "T-SQL (Microsoft)",
                    SkillType = SkillTypeEnum.Database,
                    ExpertiseScore = 0.7F,
                    ExperienceYears = 13
                }
            };
        }
    }
}