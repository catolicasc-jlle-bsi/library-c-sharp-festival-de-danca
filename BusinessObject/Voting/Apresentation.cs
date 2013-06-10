using BusinessObject.Geolocation;
using System;

namespace BusinessObject.Voting
{
    public class Apresentation
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime FinishVote { get; set; }
        public Category Category { get; set; }
        public Location Location { get; set; }
    }
}
