using System;
using System.Collections.Generic;

namespace GolfScoreStoringWebApplication.Models
{
    public partial class PlayerScore
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Guid HoleId { get; set; }
        public string PlayerId { get; set; }
        public int PlayerStrokes { get; set; }

        public virtual Game Game { get; set; }
        public virtual HoleInfo Hole { get; set; }
        public virtual AspNetUsers Player { get; set; }
    }
}
