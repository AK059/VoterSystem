using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VoterSystem.Models;

namespace VoterSystem.Data
{
    public class ApplicantDbContext : DbContext
    {
        public ApplicantDbContext(DbContextOptions<ApplicantDbContext> options)
            : base(options)
        {
        }
        public DbSet<VoterSystem.Models.Applicant> Applicant { get; set; }
        public DbSet<VoterSystem.Models.ApplicantVotes> ApplicantVotes { get; set; }
        public DbSet<VoterSystem.Models.Election> Election { get; set; }
        public DbSet<VoterSystem.Models.Elector> Elector { get; set; }

    }
}
