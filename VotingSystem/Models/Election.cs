using System;

namespace VotingSystem.Models
{
    public class Election
    {
        public string ElectionId { get; set; }
        public string Post { get; set; }
        public int NoOfCandidates { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return $"{ElectionId}: {Post} ";
        }
    }
}
