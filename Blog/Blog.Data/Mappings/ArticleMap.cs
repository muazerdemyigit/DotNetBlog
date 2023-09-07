using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Deneme Makalesi 1",
                Content = "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.",
                ViewCount = 15,
                CategoryId = Guid.Parse("A9FF72A1-9D62-43B7-8613-35B74C42A166"),
                ImageId = Guid.Parse("2CB1551B-8FFD-4A50-B1B1-B9E8EE973555"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.",
                ViewCount = 15,
                CategoryId = Guid.Parse("79CACE82-03CF-489A-92DE-746F3C32C527"),
                ImageId = Guid.Parse("3C499DC8-0F63-44CB-A060-32183D00493E"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now
            }
            );
        }
    }
}
