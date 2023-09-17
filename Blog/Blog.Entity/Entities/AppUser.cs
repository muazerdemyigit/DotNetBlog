using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("2CB1551B-8FFD-4A50-B1B1-B9E8EE973555");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
