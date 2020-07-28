using portfolio.Models;
using System.Collections.Generic;

namespace portfolio.Data
{
    public interface ISkillsRepo
    {
        IEnumerable<Skill> GetSkills();
    }
}