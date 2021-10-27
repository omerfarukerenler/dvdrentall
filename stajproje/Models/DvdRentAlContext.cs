using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace stajproje.Models
{
    public partial class DvdRentAlContext : DbContext
    {
        public DvdRentAlContext()
        {
        }

        public DvdRentAlContext(DbContextOptions<DvdRentAlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<ActorInfo> ActorInfos { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerList> CustomerLists { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }
        public virtual DbSet<FilmCategory> FilmCategories { get; set; }
        public virtual DbSet<FilmList> FilmLists { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<NicerButSlowerFilmList> NicerButSlowerFilmLists { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<SalesByFilmCategory> SalesByFilmCategories { get; set; }
        public virtual DbSet<SalesByStore> SalesByStores { get; set; }
        public virtual DbSet<StaffList> StaffLists { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=dvdrental;Username=postgres;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum(null, "mpaa_rating", new[] { "G", "PG", "PG-13", "R", "NC-17" })
                .HasAnnotation("Relational:Collation", "English_United States.1254");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Activebool).HasDefaultValueSql("true");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('now'::text)::date");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasIndex(e => e.Fulltext, "film_fulltext_idx")
                    .HasMethod("gist");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");

                entity.Property(e => e.RentalDuration).HasDefaultValueSql("3");

                entity.Property(e => e.RentalRate)
                    .HasPrecision(4, 2)
                    .HasDefaultValueSql("4.99");

                entity.Property(e => e.ReplacementCost)
                    .HasPrecision(5, 2)
                    .HasDefaultValueSql("19.99");
            });

            modelBuilder.Entity<FilmActor>(entity =>
            {
                entity.HasKey(e => new { e.ActorId, e.FilmId })
                    .HasName("film_actor_pkey");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<FilmCategory>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.CategoryId })
                    .HasName("film_category_pkey");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<FilmList>(entity =>
            {
                entity.Property(e => e.Price).HasPrecision(4, 2);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");

                entity.Property(e => e.Name).IsFixedLength(true);
            });

            modelBuilder.Entity<NicerButSlowerFilmList>(entity =>
            {
                entity.Property(e => e.Price).HasPrecision(4, 2);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Amount).HasPrecision(5, 2);

                entity.HasOne(d => d.Rental)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.RentalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("payment_rental_id_fkey");
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("true");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("now()");
            });

            modelBuilder.HasSequence("actor_actor_id_seq");

            modelBuilder.HasSequence("address_address_id_seq");

            modelBuilder.HasSequence("category_category_id_seq");

            modelBuilder.HasSequence("city_city_id_seq");

            modelBuilder.HasSequence("country_country_id_seq");

            modelBuilder.HasSequence("customer_customer_id_seq");

            modelBuilder.HasSequence("film_film_id_seq");

            modelBuilder.HasSequence("inventory_inventory_id_seq");

            modelBuilder.HasSequence("language_language_id_seq");

            modelBuilder.HasSequence("payment_payment_id_seq");

            modelBuilder.HasSequence("rental_rental_id_seq");

            modelBuilder.HasSequence("staff_staff_id_seq");

            modelBuilder.HasSequence("store_store_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
