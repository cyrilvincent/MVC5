using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;


namespace FormationMVC.Library
{
    public class ProductContext : DbContext
    {
        static ProductContext()
        {
            Database.SetInitializer<ProductContext>(new DropCreateDatabaseIfModelChanges<ProductContext>());
        }

        public ProductContext() : base("Name=ProductContext") {}

        public DbSet<VideoCategory> VideoCategories { get; set; }
        public DbSet<VideoRecording> VideoRecordings { get; set; }

        public DbSet<MusicCategory> MusicCategories { get; set; }
        public DbSet<MusicRecording> MusicRecordings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoCategory>().ToTable("video_categories");
            modelBuilder.Entity<VideoCategory>().HasKey(t => t.ID);
            modelBuilder.Entity<VideoCategory>().
                Property(t => t.ID).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); ;
            
            modelBuilder.Entity<VideoCategory>().Property(t => t.Name).HasColumnName("name");

            modelBuilder.Entity<VideoRecording>().ToTable("video_recordings");
            modelBuilder.Entity<VideoRecording>().Property(t => t.Id).HasColumnName("recording_id");
            modelBuilder.Entity<VideoRecording>().Property(t => t.Director).HasColumnName("director");
            modelBuilder.Entity<VideoRecording>().Property(t => t.Title).HasColumnName("title");
            modelBuilder.Entity<VideoRecording>().Property(t => t.Category).HasColumnName("category");
            modelBuilder.Entity<VideoRecording>().Property(t => t.ImageName).HasColumnName("image_name");
            modelBuilder.Entity<VideoRecording>().Property(t => t.YearReleased).HasColumnName("year_released");
            modelBuilder.Entity<VideoRecording>().Property(t => t.Price).HasColumnName("price");
            modelBuilder.Entity<VideoRecording>().Property(t => t.StockCount).HasColumnName("stock_count");

            modelBuilder.Entity<MusicCategory>().ToTable("music_categories");
            modelBuilder.Entity<MusicCategory>().Property(t => t.ID).HasColumnName("id");
            modelBuilder.Entity<MusicCategory>().Property(t => t.Name).HasColumnName("name");


            modelBuilder.Entity<MusicRecording>().ToTable("music_recordings");
            modelBuilder.Entity<MusicRecording>().Property(t => t.Id).HasColumnName("recording_id");
            modelBuilder.Entity<MusicRecording>().Property(t => t.ArtistName).HasColumnName("artist_name");
            modelBuilder.Entity<MusicRecording>().Property(t => t.Title).HasColumnName("title");
            modelBuilder.Entity<MusicRecording>().Property(t => t.Category).HasColumnName("category");
            modelBuilder.Entity<MusicRecording>().Property(t => t.ImageName).HasColumnName("image_name");
            modelBuilder.Entity<MusicRecording>().Property(t => t.NumberOfTracks).HasColumnName("num_tracks");
            modelBuilder.Entity<MusicRecording>().Property(t => t.Price).HasColumnName("price");
            modelBuilder.Entity<MusicRecording>().Property(t => t.StockCount).HasColumnName("stock_count");
        }

    }
}