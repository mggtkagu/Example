namespace AutoInspection.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Region_Name> Region_Name { get; set; }
        public virtual DbSet<RegionNameHasCode> RegionNameHasCode { get; set; }
        public virtual DbSet<Right_znak> Right_znak { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Code>()
                .HasMany(e => e.RegionNameHasCode)
                .WithRequired(e => e.Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Right_znak)
                .WithRequired(e => e.Region)
                .HasForeignKey(e => e.Region_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region_Name>()
                .HasMany(e => e.Region)
                .WithRequired(e => e.Region_Name)
                .HasForeignKey(e => e.RegionNameId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region_Name>()
                .HasMany(e => e.RegionNameHasCode)
                .WithRequired(e => e.Region_Name)
                .HasForeignKey(e => e.RegionNameId)
                .WillCascadeOnDelete(false);
        }
    }
}
