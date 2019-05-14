using System;
using System.Collections.Generic;

namespace GolfScoreStoringWebApplication.Models
{
    public partial class PlaceLocation
    {
        public PlaceLocation()
        {
            CourseInfo = new HashSet<CourseInfo>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string PostCode { get; set; }

        public virtual ICollection<CourseInfo> CourseInfo { get; set; }
    }
}
