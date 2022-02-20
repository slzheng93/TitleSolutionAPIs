using Application_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    //Represent the database
    public class TitlesDbContext : DbContext
    {
        // Constructor injection to inject our connection string (go to program.cs)
        // Database representation
        public TitlesDbContext(DbContextOptions<TitlesDbContext> options): base(options)
        {

        }

        // Database Tables
        public DbSet<Awards> Award { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<OtherName> OtherName { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<StoryLine> StoryLine { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<TitleGenre> TitleGenre { get; set; }
        public DbSet<Titleparticipant> TitleParticipant { get; set; }


    }
}
