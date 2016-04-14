using FizzWare.NBuilder;
using RedditLab.Models;

namespace RedditLab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RedditLabDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RedditLabDbContext context)
        {
      
            var posts = Builder<Post>.CreateListOfSize(10).All()
                .With(p => p.UpVote = Faker.NumberFaker.Number(0, 100))
                .With(p => p.DownVote = Faker.NumberFaker.Number(0, 100))
                .With(p => p.Title = Faker.TextFaker.Sentences(1))
                .With(p => p.Author = Faker.NameFaker.FirstName())
                .With(p => p.Posted = Faker.DateTimeFaker.DateTime())
        .Build();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
