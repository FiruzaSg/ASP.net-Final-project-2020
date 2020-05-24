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
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogText> BlogTexts { get; set; }
        public DbSet<BlogTitle> BlogTitles { get; set; }
        public DbSet<CaseStudy> CaseStudies { get; set; }
        public DbSet<CaseStudySpec> CaseStudySpecs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUs  { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<LikeableArea> LikeableAreas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceSpec> ServiceSpecs  { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        

    }

}
