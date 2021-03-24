using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterSystem.Models
{
    //Add class here(Applicant)
    public class Applicant
    {
     public int Id { get; set; }
     
     public string Name { get; set; }
        [Required] //Here add forigen key
        public string ApplicantProfileWebSite { get; set; }
    }
}
