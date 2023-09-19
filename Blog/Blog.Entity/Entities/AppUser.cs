using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("0c74db56-b259-4303-b36e-2f7fbfec75a4");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
