namespace OOPLAST9
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyBase : DbContext
    {
        public MyBase()
            : base("name=MyBase")
        {
        }

        public virtual DbSet<USERS_INFO> USERS_INFO { get; set; }
        public virtual DbSet<USERS_LOG> USERS_LOG { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USERS_LOG>()
                .HasMany(e => e.USERS_INFO)
                .WithOptional(e => e.USERS_LOG)
                .HasForeignKey(e => e.UserID);
        }
    }
}
