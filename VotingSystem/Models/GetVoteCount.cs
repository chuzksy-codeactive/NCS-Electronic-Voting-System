namespace VotingSystem.Models
{
    public class GetVoteCount
    {
        public string  VoterPin { get; set; }
        public string CandidatePin { get; set; }
        public string Post { get; set; }
        public int Count { get; set; }
    }
}
