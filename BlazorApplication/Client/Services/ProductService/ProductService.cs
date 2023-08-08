using BlazorApplication.Shared;

namespace BlazorApplication.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
		public List<Product> Products { get; set; } = new();

		public void LoadProducts()
		{
			Products = new List<Product>()
			{
				new Product()
				{
					Id=1,
					Title = "Harry Potter and the Philosopher's Stone",
					Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school and with the help of his friends, Ron Weasley and Hermione Granger, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
					Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg",
					Price = 10.99m,
					OriginalPrice=15.99m,
					CategoryId=1
				},
				new Product()
				{
					Id=2,
					Title = "Harry Potter and the Chamber of Secrets",
					Description = "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the \"Chamber of Secrets\" has been opened and that the \"heir of Slytherin\" would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
					Image = "https://upload.wikimedia.org/wikipedia/en/5/5c/Harry_Potter_and_the_Chamber_of_Secrets.jpg",
					Price = 10.99m,
					OriginalPrice=15.99m,
					CategoryId=2
				},
				new Product()
				{
					Id=3,
					Title = "Harry Potter and the Prisoner of Azkaban",
					Description = "Harry Potter and the Prisoner of Azkaban is a fantasy novel written by British author J. K. Rowling and is the third in the Harry Potter series. The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.",
					Image = "https://upload.wikimedia.org/wikipedia/en/a/a0/Harry_Potter_and_the_Prisoner_of_Azkaban.jpg",
					Price = 10.99m,
					OriginalPrice=15.99m,
					CategoryId=1
				},
			};
		}
	}
}