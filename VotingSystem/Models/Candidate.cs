using System.Drawing;
using System.Security;

namespace VotingSystem.Models
{
    public class Candidate
    {
        public string CandidatePin { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Gender { get; set; }
        public string Post { get; set; }
        public string Manifesto { get; set; }
        public Image PicImage { get; set; }
        public byte[] Img { get; set; }

        public string Fullname => $"{Firstname} {Lastname}";

        public override string ToString()
        {
            return $"{CandidatePin}: {Firstname} {Lastname}";
        }
    }
}
