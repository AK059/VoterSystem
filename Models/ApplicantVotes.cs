using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterSystem.Models
{
    //Add Class (ApplicantVotes)
    public class ApplicantVotes
    {
     public int Id { get; set; }
      public string Applicant { get; set; }
        [Required]
        public int ElectionCount { get; set; }
    }
}
