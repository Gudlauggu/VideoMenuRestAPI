﻿
using Microsoft.EntityFrameworkCore;
using VideoMenuDAL.Entities;


namespace VideoMenuDAL.Context
{
    class VideoAppContext : DbContext
    {
        private static DbContextOptions<VideoAppContext> options =
            new DbContextOptionsBuilder<VideoAppContext>().UseInMemoryDatabase("TheDB").Options;


        /*public VideoAppContext() : base(options)
        {
            
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:videomenuserver.database.windows.net,1433;Initial Catalog=VideoMenuDB;Persist Security Info=False;User ID=gudlaug;Password=Banana13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
