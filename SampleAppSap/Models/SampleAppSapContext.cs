using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using SampleAppSap.Data;

namespace SampleAppSap.Models
{
    public class SampleAppSapContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        public SampleAppSapContext() : base("name=SampleAppSapContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<SampleAppSap.Models.Movie> Movies { get; set; }
    }
}
