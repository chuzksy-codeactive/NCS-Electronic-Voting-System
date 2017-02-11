using System.Drawing;

namespace VotingSystem.Models
{
    public class Voters
    {
        public string VoterPin { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public Image VoterImg { get; set; }

        public byte[] ImgBytes { get; set; }
    }
}
