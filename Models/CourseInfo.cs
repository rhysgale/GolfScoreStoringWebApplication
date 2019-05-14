using System;
using System.Collections.Generic;

namespace GolfScoreStoringWebApplication.Models
{
    public partial class CourseInfo
    {
        public CourseInfo()
        {
            Game = new HashSet<Game>();
            HoleInfo = new HashSet<HoleInfo>();
        }

        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public string Name { get; set; }

        public virtual PlaceLocation Location { get; set; }
        public virtual ICollection<Game> Game { get; set; }
        public virtual ICollection<HoleInfo> HoleInfo { get; set; }
    }
}
