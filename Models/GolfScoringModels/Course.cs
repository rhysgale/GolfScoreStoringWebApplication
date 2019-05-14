using System;

namespace GolfScoreStoringWebApplication.Models.GolfScoringModels
{
    public class Course
    {
        public Course(string name, string postCode)
        {
            CourseName = name;
            CoursePostcode = postCode;
        }

        //Information regarding the course played
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public string CoursePostcode { get; set; }
    }
}
