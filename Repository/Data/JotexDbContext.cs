using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
   public class JotexDbContext:DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options) { }

        public DbSet<Agent> Agents{ get; set; }
        public DbSet<BestPlan> BestPlans { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<LikeableArea> LikeableAreas { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }

    }

}
