using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journey.Models
{
    public class JournyDbContext : DbContext
    {
        public JournyDbContext(DbContextOptions<JournyDbContext> options) : base(options)
        { }

        // adding composite primary keys 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FollwedBy>()
                .HasKey(fb => new { fb.UserId , fb.FollowedByUserId });

            modelBuilder.Entity<NearbyDestinationsMapping>()
                .HasKey(mapping => new { mapping.DestinationId, mapping.NearbyDestinationId });
        }

        // public DbSet<User> Users { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AttractionImage> AttractionImages { get; set; }
        public virtual DbSet<Attraction> Attractions { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<DestinationAttribute> DestinationAttributes { get; set; }
        public virtual DbSet<DestinationCatogary> DestinationCatogaries { get; set; }
        public virtual DbSet<DestinationComment> DestinationComments { get; set; }
        public virtual DbSet<DestinationImage> DestinationImages { get; set; }
        public virtual DbSet<DestinationPopularity> DestinationPopularities { get; set; }
        public virtual DbSet<DestinationTravellingMode> DestinationTravellingModes { get; set; }
        public virtual DbSet<DestinationAttributesType> DesttinationAttributesTypes { get; set; }
        public virtual DbSet<FollwedBy> FollwedBies { get; set; }
        public virtual DbSet<NearbyDestinationsMapping> NearbyDestinationsMappings { get; set; }
        public virtual DbSet<NearbyDestinationSuggestion> NearbyDestinationSuggestions { get; set; }
        public virtual DbSet<PopularityType> PopularityTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFeedback> UserFeedbacks { get; set; }
        public virtual DbSet<WishLIst> WishLIsts { get; set; }

    }
}

