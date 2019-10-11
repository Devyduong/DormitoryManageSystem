namespace DormitoryManageSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Dormitory : DbContext
    {
        public Dormitory()
            : base("name=Dormitory")
        {
        }

        public virtual DbSet<CONTACT> CONTACTs { get; set; }
        public virtual DbSet<HOMEFLEET> HOMEFLEETs { get; set; }
        public virtual DbSet<RENT> RENTs { get; set; }
        public virtual DbSet<ROOM> ROOMs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOMEFLEET>()
                .HasMany(e => e.ROOMs)
                .WithOptional(e => e.HOMEFLEET1)
                .HasForeignKey(e => e.HOMEFLEET);

            modelBuilder.Entity<RENT>()
                .Property(e => e.RENTER)
                .IsUnicode(false);

            modelBuilder.Entity<RENT>()
                .Property(e => e.THELEASE)
                .IsUnicode(false);

            modelBuilder.Entity<ROOM>()
                .HasMany(e => e.RENTs)
                .WithOptional(e => e.ROOM1)
                .HasForeignKey(e => e.ROOM);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.STUDENTID)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.PHONENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .HasMany(e => e.RENTs)
                .WithOptional(e => e.STUDENT)
                .HasForeignKey(e => e.RENTER);

            modelBuilder.Entity<USER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORDS)
                .IsUnicode(false);
        }
    }
}
