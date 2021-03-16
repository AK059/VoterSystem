using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoterSystem.Models
{
    public class Election
    {
        public int Id { get; set; }
       public int ElectorId { get; set; }
      public int ApplicantId { get; set; }
     public Elector Elector { get; set; }
    public Applicant Applicant { get; set; }


    }
}
