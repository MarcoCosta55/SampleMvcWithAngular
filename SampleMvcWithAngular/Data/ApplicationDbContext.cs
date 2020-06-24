namespace SampleMvcWithAngular.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SampleMvcWithAngular.Models;

    public class ApplicationDbContext : DbContext
    {
        // Your context has been configured to use a 'ApplicationDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SampleMvcWithAngular.Data.ApplicationDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ApplicationDbContext' 
        // connection string in the application configuration file.
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<JoggingRecord> JoggingRecords { get; set; }
    }
}