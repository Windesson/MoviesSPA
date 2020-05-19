using SampleAppSap.Models;
using System;
using System.Data.Entity;

namespace SampleAppSap.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<SampleAppSapContext>
    {
        protected override void Seed(SampleAppSapContext context)
        {

            context.Movies.Add( new Movie()
            {
                ID = 0,
                Title = "ActionTitle",
                Year = 2020,
                Genre = "Action",
                Rating = "PG-13" }
            );

            context.SaveChanges();
        }
    }
}