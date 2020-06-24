using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MusicStore.DBModels
{
    public partial class MUSIC_STOREContext : DbContext
    {
        public MUSIC_STOREContext()
        {
        }

        public MUSIC_STOREContext(DbContextOptions<MUSIC_STOREContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cd> Cd { get; set; }
        public virtual DbSet<DeluxeEdition> DeluxeEdition { get; set; }
        public virtual DbSet<Dvd> Dvd { get; set; }
        public virtual DbSet<TShirt> TShirt { get; set; }
        public virtual DbSet<Vinyl> Vinyl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MUSIC_STORE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cd>(entity =>
            {
                entity.ToTable("CD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnName("album_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasColumnName("artist_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Autograph).HasColumnName("autograph");

                entity.Property(e => e.CoverImage)
                    .HasColumnName("cover_image")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LabelName)
                    .HasColumnName("label_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NumberSongs).HasColumnName("number_songs");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<DeluxeEdition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnName("album_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasColumnName("artist_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Autograph).HasColumnName("autograph");

                entity.Property(e => e.CoverImage)
                    .HasColumnName("cover_image")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LabelName)
                    .HasColumnName("label_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NumberAlbums).HasColumnName("number_albums");

                entity.Property(e => e.NumberSongs).HasColumnName("number_songs");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Dvd>(entity =>
            {
                entity.ToTable("DVD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnName("album_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasColumnName("artist_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Autograph).HasColumnName("autograph");

                entity.Property(e => e.CoverImage)
                    .HasColumnName("cover_image")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LabelName)
                    .HasColumnName("label_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NumberSongs).HasColumnName("number_songs");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TShirt>(entity =>
            {
                entity.ToTable("T_shirt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasColumnName("artist_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Autograph).HasColumnName("autograph");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.TShirtImage)
                    .HasColumnName("t_shirt_image")
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vinyl>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnName("album_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasColumnName("artist_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Autograph).HasColumnName("autograph");

                entity.Property(e => e.CoverImage)
                    .HasColumnName("cover_image")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LabelName)
                    .HasColumnName("label_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NumberSongs).HasColumnName("number_songs");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
