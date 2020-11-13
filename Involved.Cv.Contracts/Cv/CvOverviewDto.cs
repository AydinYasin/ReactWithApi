using Involved.Cv.Contracts.Cv;
using System;
using System.Collections.Generic;
using System.Text;

namespace Involved.Cv.Contracts
{
    public class CvOverviewDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Skill { get; set; }
        public string Township { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public List<ProgramLanguageDto> SkillOverviews { get; set; }
    }
}
