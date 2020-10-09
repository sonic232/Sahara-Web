using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SaharaWeb.DataSource.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaharaWeb.DataSource.Contexts
{
    public static class TestData
    {
        internal static void AddDataIfNeeded(IApplicationBuilder app)
        {
            using (var context = app.ApplicationServices.GetService<SaharaDbContext>())
            {
                AddDataIfNeeded(context);
            }
        }

        internal static void AddDataIfNeeded(SaharaDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;
            }

            InitializeData(context);
        }

        internal static IEnumerable<Category> SeedCategories = new List<Category>
        {
            new Category{
                Id = 1,
                LastModified = DateTime.Now,
                Name = "Redstone",
                Description = "Any components primarily used in Redstone Contraptions, including Redstone, Repeaters, Comparators, Pistons, and similar."
            },
            new Category
            {
                Id = 2,
                LastModified = DateTime.Now,
                Name = "Precious Blocks",
                Description = "Any blocks that have significant value due to their rarity or the requirement to smelt them from ore into an ingot"
            },
            new Category
            {
                Id = 3,
                LastModified = DateTime.Now,
                Name = "Building Materials",
                Description = "Any blocks used primarily for building a structure or scaffolding that do not fit in other categories"
            }
        };

        internal static IEnumerable<Product> SeedProducts = new List<Product>
        {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                LastModified = DateTime.Now,
                Name = "Stack of Redstone Dust (64)",
                Description = "A stack of sixty-four (64) Redstone Dust, a crafting component of many Redstone Components and used to create circuits",
                Price = 1
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                LastModified = DateTime.Now,
                Name = "Stack of Redstone Torches (64)",
                Description = "A stack of sixty-four (64) Redstone Torches, a crafting component of many Redstone Components and used to power devices or create logic gates",
                Price = 2
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                LastModified = DateTime.Now,
                Name = "Set of Observers (16)",
                Description = "A set of sixteen (16) Observer blocks. Observer Blocks create a one-redstone-tick pulse whenever it detects a change to the block it is observing. Useful for automating farms and sending brief signals",
                Price = 5
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                LastModified = DateTime.Now,
                Name = "Stack of Iron Blocks (64)",
                Description = "A stack of sixty-four (64) Iron Blocks. Each Iron Block contains 9 ingots of iron and can be used for crafting many common tools and a few redstone components such as Hoppers and Pistons",
                Price = 10
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                LastModified = DateTime.Now,
                Name = "Stack of Lapis (64)",
                Description = "A stack of sixty-four (64) Lapis, a material used to dye items blue as well as a necessary component for Enchanting",
                Price = 10
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                LastModified = DateTime.Now,
                Name = "1 Netherite Ingot",
                Description = "Netherite Ingot, a material used to improve Diamond equipment's durability, as well as making them highly resistant to being destroyed by lava. Highly rare material.",
                Price = 20
            },
            new Product
            {
                Id = 7,
                CategoryId = 3,
                LastModified = DateTime.Now,
                Name = "4 Stacks of Dirt (256)",
                Description = "Four stacks of sixty-four (64) Dirt. A natural material that is not used in crafting for anything but Coarse Dirt. May be needed for large terraforming projects",
                Price = 1
            },
            new Product
            {
                Id = 8,
                CategoryId = 3,
                LastModified = DateTime.Now,
                Name = "2 Stacks of Scaffolding Blocks",
                Description = "Two stacks of sixty-four (64) Scaffolding Blocks, a block used for large building projects and constructed from bamboo. Removing one bamboo from beneath a connected set will drop the rest in that set unlike other blocks, as well you can climb and descend them like ladders.",
                Price = 1
            },
            new Product
            {
                Id = 9,
                CategoryId = 3,
                LastModified = DateTime.Now,
                Name = "2 Stacks of Smooth Stone",
                Description = "Two stacks of sixty-four (64) Smooth Stone, a material which can only be aquired using a Silk Touch pickaxe, or else by taking the Cobblestone aquired during mining and smelting it in your furnace. Can be easily crafted into decorative blocks and used in some redstone components.",
                Price = 1
            }
        };

        internal static void InitializeData(SaharaDbContext context)
        {
            context.Categories.AddRange(SeedCategories);
            context.SaveChanges();

            context.Products.AddRange(SeedProducts);
            context.SaveChanges();
        }
    }
}
