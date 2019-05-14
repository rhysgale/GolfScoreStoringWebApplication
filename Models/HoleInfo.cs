using System;
using System.Collections.Generic;

namespace GolfScoreStoringWebApplication.Models
{
    public partial class HoleInfo
    {
        public HoleInfo()
        {
            PlayerScore = new HashSet<PlayerScore>();
        }

        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public int Par { get; set; }
        public int Distance { get; set; }

        public virtual CourseInfo Course { get; set; }
        public virtual ICollection<PlayerScore> PlayerScore { get; set; }
    }
}
