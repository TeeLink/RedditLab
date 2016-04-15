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
            
            var posts = Builder<Post>.CreateListOfSize(20).All()
                .With(p => p.UpVote = Faker.NumberFaker.Number(0, 100))
                .With(p => p.DownVote = Faker.NumberFaker.Number(0, 100))
                .With(p => p.Title = Faker.TextFaker.Sentences(1))
                .With(p => p.Author = Faker.NameFaker.FirstName())
                .With(p => p.Posted = Faker.DateTimeFaker.DateTime())
                .With(p => p.Link = Faker.InternetFaker.Url())
                .With(p => p.Body = Faker.TextFaker.Sentences(12))
.Build();
                context.Posts.AddRange(posts);


        }

    }
}
