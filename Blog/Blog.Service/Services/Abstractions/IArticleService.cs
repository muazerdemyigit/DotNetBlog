using Blog.Entity.DTOs.Article;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task CrateArticleAsync(ArticleAddDto articleAddDto);
    }
}
