namespace BlazorApplication.Shared
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string? Image { get; set; }

        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }

        public bool IsPublic { get; set; }

        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}