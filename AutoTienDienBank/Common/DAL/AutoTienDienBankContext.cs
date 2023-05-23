using Common.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Common.DAL
{
    public class AutoTienDienBankContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public AutoTienDienBankContext() : base("Server=112.78.2.90;Database=tes26479_keydien;User Id=tes26479_keydien;Password=B6f5yi9~4")
        {

        }

        public DbSet<InformationModel> Informations { get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();
            List<DbEntityEntry> modifiedEntries = new List<DbEntityEntry>();

            //Get entries add or update to database
            foreach (var entry in entries)
            {
                if (entry.Entity is IAuditableEntity && entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    modifiedEntries.Add(entry);
                }
            }

            //Set CreatedBy, CreatedDate, UpdatedBy, UpdatedDate for IAuditableEntity

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    DateTime now = DateTime.Now;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = Environment.UserName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = Environment.UserName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
