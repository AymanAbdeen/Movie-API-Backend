using System;
using Microsoft.EntityFrameworkCore;



namespace Movies{

public class MovieContext : DbContext {

    public MovieContext(DbContextOptions<MovieContext> options)
     : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=DB/movies.db");
    }

    public DbSet<Movie> Movies { get; set; }
    // gör movie som tabel
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<ProductCategory>()
            .HasKey(c => new { c.MovieId, c.CategoryId });

        modelBuilder.Entity<ProductCategory>()
            .HasOne(pc => pc.Movie)
            .WithMany(p => p.ProductCategorys)
            .HasForeignKey(pc => pc.MovieId);

        modelBuilder.Entity<ProductCategory>()
            .HasOne(pc => pc.Category)
            .WithMany(c => c.ProductCategorys)
            .HasForeignKey(pc => pc.CategoryId);





        modelBuilder.Entity<OrderDetial>()
            .HasKey(o => new { o.MovieId, o.OrderId });

        modelBuilder.Entity<OrderDetial>()
            .HasOne(od => od.Movie)
            .WithMany(o => o.OrderDetials)
            .HasForeignKey(od => od.MovieId);

        modelBuilder.Entity<OrderDetial>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetials)
            .HasForeignKey(od => od.OrderId); 
    } 
}



}