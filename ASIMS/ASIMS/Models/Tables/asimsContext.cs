using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASIMS.Models.Tables
{
    public partial class asimsContext : DbContext
    {
        public asimsContext()
        {
        }

        public asimsContext(DbContextOptions<asimsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Cashlist> Cashlist { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<Inforofvehicle> Inforofvehicle { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<Shopingcart> Shopingcart { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Suppler> Suppler { get; set; }
        public virtual DbSet<Systemimg> Systemimg { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=sql123456; database=asims;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Ano)
                    .HasName("PRIMARY");

                entity.ToTable("address");

                entity.Property(e => e.Ano).HasColumnType("int(11)");

                entity.Property(e => e.Acity).HasColumnType("varchar(20)");

                entity.Property(e => e.Anation).HasColumnType("varchar(20)");

                entity.Property(e => e.Aprovince).HasColumnType("varchar(20)");

                entity.Property(e => e.County).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Cashlist>(entity =>
            {
                entity.HasKey(e => e.Vno)
                    .HasName("PRIMARY");

                entity.ToTable("cashlist");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.Property(e => e.Vnumber).HasColumnType("int(11)");

                entity.HasOne(d => d.VnoNavigation)
                    .WithOne(p => p.Cashlist)
                    .HasForeignKey<Cashlist>(d => d.Vno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_13");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasKey(e => e.Vno)
                    .HasName("PRIMARY");

                entity.ToTable("income");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.Property(e => e.Vnumber).HasColumnType("int(11)");

                entity.HasOne(d => d.VnoNavigation)
                    .WithOne(p => p.Income)
                    .HasForeignKey<Income>(d => d.Vno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_5");
            });

            modelBuilder.Entity<Inforofvehicle>(entity =>
            {
                entity.HasKey(e => e.Vno)
                    .HasName("PRIMARY");

                entity.ToTable("inforofvehicle");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.Property(e => e.IairInlet).HasColumnType("varchar(20)");

                entity.Property(e => e.Iconstruction).HasColumnType("varchar(20)");

                entity.Property(e => e.Idisplacement).HasColumnType("varchar(20)");

                entity.Property(e => e.IdriveMode).HasColumnType("varchar(20)");

                entity.Property(e => e.Ienergy).HasColumnType("varchar(20)");

                entity.Property(e => e.Ination).HasColumnType("varchar(20)");

                entity.Property(e => e.Inote).HasColumnType("varchar(200)");

                entity.Property(e => e.Iseatnum).HasColumnType("int(11)");

                entity.Property(e => e.Ispeedbox).HasColumnType("varchar(20)");

                entity.HasOne(d => d.VnoNavigation)
                    .WithOne(p => p.Inforofvehicle)
                    .HasForeignKey<Inforofvehicle>(d => d.Vno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_7");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.HasKey(e => e.Mno)
                    .HasName("PRIMARY");

                entity.ToTable("market");

                entity.HasIndex(e => e.Sphone)
                    .HasName("FK_Reference_3");

                entity.HasIndex(e => e.Uphone)
                    .HasName("FK_Reference_4");

                entity.HasIndex(e => e.Vno)
                    .HasName("FK_Reference_2");

                entity.Property(e => e.Mno).HasColumnType("int(11)");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pflag).HasColumnType("int(11)");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Sphone).HasColumnType("varchar(20)");

                entity.Property(e => e.Uphone).HasColumnType("varchar(20)");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.HasOne(d => d.SphoneNavigation)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.Sphone)
                    .HasConstraintName("FK_Reference_3");

                entity.HasOne(d => d.UphoneNavigation)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.Uphone)
                    .HasConstraintName("FK_Reference_4");

                entity.HasOne(d => d.VnoNavigation)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.Vno)
                    .HasConstraintName("FK_Reference_2");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.Pno)
                    .HasName("PRIMARY");

                entity.ToTable("purchase");

                entity.HasIndex(e => e.Sno)
                    .HasName("FK_Reference_11");

                entity.HasIndex(e => e.Vno)
                    .HasName("FK_Reference_10");

                entity.Property(e => e.Pno).HasColumnType("int(11)");

                entity.Property(e => e.Pnumber).HasColumnType("int(11)");

                entity.Property(e => e.PrecordDate).HasColumnType("datetime");

                entity.Property(e => e.Sno).HasColumnType("int(11)");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.HasOne(d => d.SnoNavigation)
                    .WithMany(p => p.Purchase)
                    .HasForeignKey(d => d.Sno)
                    .HasConstraintName("FK_Reference_11");

                entity.HasOne(d => d.VnoNavigation)
                    .WithMany(p => p.Purchase)
                    .HasForeignKey(d => d.Vno)
                    .HasConstraintName("FK_Reference_10");
            });

            modelBuilder.Entity<Shopingcart>(entity =>
            {
                entity.HasKey(e => e.Cno)
                    .HasName("PRIMARY");

                entity.ToTable("shopingcart");

                entity.HasIndex(e => e.Uphone)
                    .HasName("FK_Reference_8");

                entity.HasIndex(e => e.Vno)
                    .HasName("FK_Reference_9");

                entity.Property(e => e.Cno).HasColumnType("int(11)");

                entity.Property(e => e.Uphone).HasColumnType("varchar(20)");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.HasOne(d => d.UphoneNavigation)
                    .WithMany(p => p.Shopingcart)
                    .HasForeignKey(d => d.Uphone)
                    .HasConstraintName("FK_Reference_8");

                entity.HasOne(d => d.VnoNavigation)
                    .WithMany(p => p.Shopingcart)
                    .HasForeignKey(d => d.Vno)
                    .HasConstraintName("FK_Reference_9");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(e => e.Sphone)
                    .HasName("PRIMARY");

                entity.ToTable("staff");

                entity.Property(e => e.Sphone).HasColumnType("varchar(20)");

                entity.Property(e => e.CarNum).HasColumnType("int(11)");

                entity.Property(e => e.Sacademic).HasColumnType("varchar(10)");

                entity.Property(e => e.Saddress).HasColumnType("int(20)");

                entity.Property(e => e.Sage).HasColumnType("int(11)");

                entity.Property(e => e.Sname).HasColumnType("varchar(20)");

                entity.Property(e => e.Spassword).HasColumnType("varchar(20)");

                entity.Property(e => e.Ssex).HasColumnType("varchar(5)");

                entity.Property(e => e.Stype).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Suppler>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PRIMARY");

                entity.ToTable("suppler");

                entity.Property(e => e.Sno).HasColumnType("int(11)");

                entity.Property(e => e.Saddress).HasColumnType("int(20)");

                entity.Property(e => e.Sbank).HasColumnType("varchar(20)");

                entity.Property(e => e.Sbankno).HasColumnType("varchar(25)");

                entity.Property(e => e.SlinkMan).HasColumnType("varchar(20)");

                entity.Property(e => e.Sname).HasColumnType("varchar(20)");

                entity.Property(e => e.Snote).HasColumnType("varchar(50)");

                entity.Property(e => e.Sphone).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Systemimg>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PRIMARY");

                entity.ToTable("systemimg");

                entity.Property(e => e.Sno).HasColumnType("int(11)");

                entity.Property(e => e.Sname).HasColumnType("varchar(20)");

                entity.Property(e => e.Spath).HasColumnType("varchar(100)");

                entity.Property(e => e.Vno).HasColumnType("int(11)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uphone)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.Property(e => e.Uphone).HasColumnType("varchar(20)");

                entity.Property(e => e.Uaddress).HasColumnType("int(20)");

                entity.Property(e => e.Uname).HasColumnType("varchar(20)");

                entity.Property(e => e.Upassword).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.Vno)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle");

                entity.HasIndex(e => e.Vno)
                    .HasName("Vno");

                entity.Property(e => e.Vno).HasColumnType("int(11)");

                entity.Property(e => e.Vbrand).HasColumnType("varchar(20)");

                entity.Property(e => e.Vcolour).HasColumnType("varchar(20)");

                entity.Property(e => e.Vdate).HasColumnType("date");

                entity.Property(e => e.Virank).HasColumnType("varchar(20)");

                entity.Property(e => e.Vname).HasColumnType("varchar(20)");

                entity.Property(e => e.Vtype).HasColumnType("varchar(20)");
            });
        }
    }
}
