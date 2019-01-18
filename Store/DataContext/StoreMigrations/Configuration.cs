namespace Store.DataContext.StoreMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Store.Models.DataContext.StoreDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContext\StoreMigrations";
        }

        protected override void Seed(Store.Models.DataContext.StoreDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
                p => p.ArticleId,
                new Models.Entities.Products()
                {
                    ArticleId = 1,
                    ProductType = "Shoe",
                    ArticleName = "Reebok Flexagon",
                    Description = "Wavy shapes,varying color tones and unexpected angles " +
                                  "- can Japanese paper art stand as a model for an exercise shoe ? " +
                                  "Of Course!In the creation of the light, clean and airy Reebok Flexagon " +
                                  "we have been inspired by the versatility and flexibility that distinguishes " +
                                  "the paper as material and origamine as a craft.",

                    Image = "Reebok Flexagon.jpg",
                    Stock = 5,
                    Price = 60
                },
                new Models.Entities.Products()
                {
                    ArticleId = 2,
                    ProductType = "Shoe",
                    ArticleName = "Reebok Flexagon Red",
                    Description = "Wavy shapes,varying color tones and unexpected angles " +
                                  "- can Japanese paper art stand as a model for an exercise shoe ? " +
                                  "Of Course!In the creation of the light, clean and airy Reebok Flexagon " +
                                  "we have been inspired by the versatility and flexibility that distinguishes " +
                                  "the paper as material and origamine as a craft.",

                    Image = "Reebok Flexagon Red.jpg",
                    Stock = 5,
                    Price = 65
                },
                new Models.Entities.Products()
                {
                    ArticleId = 3,
                    ProductType = "Shoe",
                    ArticleName = "Reebok Flexagon Gray",
                    Description = "Wavy shapes,varying color tones and unexpected angles " +
                                  "- can Japanese paper art stand as a model for an exercise shoe ? " +
                                  "Of Course!In the creation of the light, clean and airy Reebok Flexagon " +
                                  "we have been inspired by the versatility and flexibility that distinguishes " +
                                  "the paper as material and origamine as a craft.",

                    Image = "Reebok Flexagon Gray.jpg",
                    Stock = 5,
                    Price = 60
                },
                new Models.Entities.Products()
                {

                }
            );
        }
    }
}
