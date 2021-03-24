using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterSystem.Models
{
    //Add class ELector
    public class Elector
    {
        public int Id { get; set; }
            [Required]//add forigen key
       public string Name { get; set; }
      public string Email { get; set; }
     }
}
