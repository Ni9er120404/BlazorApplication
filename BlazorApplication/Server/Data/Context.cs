using BlazorApplication.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApplication.Server.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            //_ = Database.EnsureDeleted();
            _ = Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<ProductVariant>().HasKey(productVariant => new { productVariant.ProductId, productVariant.EditionId });
            _ = modelBuilder.Entity<Product>().HasData(_products);
            _ = modelBuilder.Entity<Category>().HasData(_categories);
            _ = modelBuilder.Entity<Edition>().HasData(_editions);
        }

        private readonly List<Product> _products = new()
        {
            new Product()
            {
                Id=1,
                Title = "Harry Potter and the Philosopher's Stone",
                Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school and with the help of his friends, Ron Weasley and Hermione Granger, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg",
                CategoryId=1
            },
            new Product()
            {
                Id=2,
                Title = "Harry Potter and the Chamber of Secrets",
                Description = "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the \"Chamber of Secrets\" has been opened and that the \"heir of Slytherin\" would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
                Image = "https://upload.wikimedia.org/wikipedia/en/5/5c/Harry_Potter_and_the_Chamber_of_Secrets.jpg",
                CategoryId=2
            },
            new Product()
            {
                Id=3,
                Title = "Harry Potter and the Prisoner of Azkaban",
                Description = "Harry Potter and the Prisoner of Azkaban is a fantasy novel written by British author J. K. Rowling and is the third in the Harry Potter series. The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.",
                Image = "https://upload.wikimedia.org/wikipedia/en/a/a0/Harry_Potter_and_the_Prisoner_of_Azkaban.jpg",
                CategoryId=1
            },
        };

        private readonly List<Category> _categories = new()
        {
            new Category()
                {
                    Id=1,
                    Name = "Fantasy",
                    Url="fantasy",
                    Icon="fantasy"
                },
                new Category()
                {
                    Id=2,
                    Name = "Science Fiction",
                    Url="science-fiction",
                    Icon="science-fiction"
                },
                new Category()
                {
                    Id=3,
                    Name = "Horror",
                    Url="horror",
                    Icon="horror"
                }
        };

        private readonly List<Edition> _editions = new()
        {
            new Edition()
            {
                Id=1,
                Name = "Default"
            },
            new Edition()
            {
                Id=2,
                Name = "Paperback",
            },
            new Edition()
            {
                Id=3,
                Name = "E-Book",
            },
            new Edition()
            {
                Id=4,
                Name = "Audio",
            }
        };

        private readonly List<ProductVariant> _productVariants = new()
        {
            new ProductVariant
            {
                ProductId = 1,
                EditionId = 1,
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                EditionId = 2,
                Price = 7.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                EditionId = 3,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                EditionId = 4,
                Price = 7.99m,
                OriginalPrice = 14.99m
            },
            new ProductVariant
            {
                ProductId = 2,
                EditionId = 1,
                Price = 6.99m
            },
            new ProductVariant
            {
                ProductId = 2,
                EditionId = 2,
                Price = 166.66m,
                OriginalPrice = 249.00m
            },
            new ProductVariant
            {
                ProductId = 2,
                EditionId = 3,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ProductVariant
            {
                ProductId = 2,
                EditionId = 4,
                Price = 73.74m,
                OriginalPrice = 400m
            },
            new ProductVariant
            {
                ProductId = 3,
                EditionId = 1,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                EditionId = 2,
                Price = 69.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                EditionId = 3,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                EditionId = 4,
                Price = 9.99m,
                OriginalPrice = 24.99m,
            }
        };
    }
}