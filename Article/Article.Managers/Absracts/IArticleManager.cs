using Article.DTO;
using System.Collections.Generic;

namespace Article.Managers.Absracts
{
    public interface IArticleManager
    {
        List<ArticleDTO> GetAll();
        ArticleDTO GetById(int id);
        List<ArticleDTO> GetByContent(string article);
        void RemoveArticle(int id);
        void AddArticle(ArticleDTO article);
        void UpdateArticle(int id, ArticleDTO article);
    }
}
