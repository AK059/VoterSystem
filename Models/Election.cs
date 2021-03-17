using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoterSystem.Models
{
    //Add Public class (Election)
    public class Election
    {
        public int Id { get; set; }
       public int ElectorId { get; set; }
        public Elector Elector { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }





    }
}
