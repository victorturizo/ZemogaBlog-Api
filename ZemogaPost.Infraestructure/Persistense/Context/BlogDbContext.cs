using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZemogaPost.Domain.Entities;

namespace ZemogaPost.Infraestructure.Persistense.Context
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext()
        {

        }
        public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-HR9EAJN;Database=ZemogaBlog;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
