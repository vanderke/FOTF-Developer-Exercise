using WebApplication1.Db;

namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Db.DataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Db.DataModel context)
        {
            //  This method will be called after migrating to the latest version.

            context.Books.AddOrUpdate(new Book[]
            {
                new Book
                {
                    BookId = 1,
                    Title = "Ready to Wed: 12 Ways to Start a Marriage You'll Love",
                    Author = "Greg Smalley (Editor), Erin Smalley (Editor)",
                    ImgUrl = "http://ecx.images-amazon.com/images/I/51TGr29tRBL._SX331_BO1,204,203,200_.jpg",
                    Summary = @"You’re engaged, and the checklist for the day of your dreams is a mile long. In the who, what, where, and how of planning, the why can be forgotten.

Ready to Wed discusses 12 Traits of a thriving marriage and offers a variety of topics to guide and advise those preparing to say, “I do!”"
                }
            });

            context.SaveChanges();

            context.Blurbs.AddOrUpdate(new Blurb[]
            {
                new Blurb { BookId = 1, BlurbId = 1, 
                    Title="Life Long Commitment",
                      Summary = "Lifelong commitment begins with a decision that divorce is not an option and a determination to invest in your marriage every day."
                },

                new Blurb { BookId = 1, BlurbId = 2, 
                    Title = "Spending Enjoyable Time Together",
                    Summary = "In the busyness of life, remember that love isn’t self-sufficient. Your marriage must be constantly fed and nurtured by spending regular time together."
                },

                new Blurb { BookId = 1, BlurbId = 3, 
                    Title = "Positive Communication",
                    Summary = "Communication gives life to marriage when you spend time getting to know your spouse and allowing yourself to be deeply known by him or her."
                },

                new Blurb { BookId = 1, BlurbId = 4, 
                    Title = "Shared Spiritual Intimacy",
                    Summary = "Couples who have a deep, shared faith and have Christ at the center of their marriage have a more satisfying relationship and deeper intimacy."
                },

                new Blurb { BookId = 1, BlurbId = 5, 
                    Title = "Healthy Individuals",
                    Summary = "A healthy marriage is made of two healthy people. Commit to a lifetime of spiritual, emotional, physical and mental growth and development."
                },

                new Blurb { BookId = 1, BlurbId = 6, 
                    Title = "Mutually Satisfying Physical Intimacy",
                    Summary = "Sex is God’s gift to a married couple as a way to experience the deepest, most profound intimacy possible—the two becoming one flesh."
                },

                new Blurb { BookId = 1, BlurbId = 7, 
                    Title = "Healthy Conflict Management",
                    Summary = "Conflict is an inevitable part of marriage, but handled well, healthy conflict can become an opportunity for deeper intimacy and connection."
                },

                new Blurb { BookId = 1, BlurbId = 8, 
                    Title = "Shared Responsibility (Teamwork)",
                    Summary = "Marriage means you are always on the same team. Make decisions and divide household responsibilities in a way that honors both of you."
                },

                new Blurb { BookId = 1, BlurbId = 9, 
                    Title = "Coping With Change, Stress and Crises",
                    Summary = "You will face challenges on your journey together. Always fight for your marriage and trust that God will turn your pain to blessing."
                },

                new Blurb { BookId = 1, BlurbId = 10, 
                    Title = "Cherish",
                    Summary = "Created by God, your fiancé(e) is of infinite worth and value. Reflect often on the things that you love and cherish about your future spouse."
                },

                new Blurb { BookId = 1, BlurbId = 11, 
                    Title = "Nourish",
                    Summary = "Love involves action and behavior. You need to nourish your relationship with your fiancé(e) in ways that speak love to him or her."
                },

                new Blurb { BookId = 1, BlurbId = 12, 
                    Title = "Community-Mindedness",
                    Summary = "Connecting regularly with like-minded couples who are committed to the good of your relationship is vital to the success of your marriage."
                }
            });

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
