namespace StudentHouseMembershipCart.Application.Features.Categories.Queries
{
    public class CategoryData
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Image { get; set; }
        public DateTime? Created { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool? IsDelete { get; set; }

    }
}