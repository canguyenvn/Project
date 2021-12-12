using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.EF
{
    public partial class IVSDBContext : DbContext
    {
        public IVSDBContext()
            : base("name=IVSDBContext")
        {
        }

        public virtual DbSet<tbl_Billing> tbl_Billing { get; set; }
        public virtual DbSet<tbl_Billing_Detail> tbl_Billing_Detail { get; set; }
        public virtual DbSet<tbl_Mode> tbl_Mode { get; set; }
        public virtual DbSet<tbl_Notice> tbl_Notice { get; set; }
        public virtual DbSet<tbl_Order> tbl_Order { get; set; }
        public virtual DbSet<tbl_Quotation> tbl_Quotation { get; set; }
        public virtual DbSet<tbl_Quotation_Detail> tbl_Quotation_Detail { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }
        public virtual DbSet<tbl_User_Address> tbl_User_Address { get; set; }
        public virtual DbSet<tbl_User_Detail> tbl_User_Detail { get; set; }
        public virtual DbSet<tbl_User_Relationship> tbl_User_Relationship { get; set; }
        public virtual DbSet<tbl_Order_Detail> tbl_Order_Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Billing>()
                .Property(e => e.Billing_Number)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Billing>()
                .Property(e => e.Billing_Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_Billing_Detail>()
                .Property(e => e.Billing_UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_Billing_Detail>()
                .Property(e => e.Billing_Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_Billing_Detail>()
                .Property(e => e.Billing_Discount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_Mode>()
                .Property(e => e.Mode_Name)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Mode>()
                .HasMany(e => e.tbl_User_Detail)
                .WithRequired(e => e.tbl_Mode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Mode>()
                .HasMany(e => e.tbl_User_Relationship)
                .WithRequired(e => e.tbl_Mode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Order>()
                .Property(e => e.Order_Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_Quotation>()
                .Property(e => e.Q_Number)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Quotation>()
                .Property(e => e.Customer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Quotation>()
                .Property(e => e.Q_Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_User_Relationship)
                .WithRequired(e => e.tbl_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_User_Detail>()
                .Property(e => e.User_Shortcut)
                .IsFixedLength();

            modelBuilder.Entity<tbl_User_Detail>()
                .Property(e => e.User_Honorific_Title)
                .IsFixedLength();

            modelBuilder.Entity<tbl_User_Detail>()
                .Property(e => e.User_Division)
                .IsFixedLength();

            modelBuilder.Entity<tbl_User_Detail>()
                .Property(e => e.User_Phone_Number)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Order_Detail>()
                .Property(e => e.Order_Qty)
                .HasPrecision(18, 0);
        }
    }
}
