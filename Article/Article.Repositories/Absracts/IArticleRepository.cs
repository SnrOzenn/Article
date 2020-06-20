using Article.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Repositories.Absracts
{
   public interface IArticleRepository
    {
        List<ArticleDTO> GetAll();
        ArticleDTO GetById(int id);
        List<ArticleDTO> GetByContent(string article);
        void RemoveArticle(int id);
        void AddArticle(ArticleDTO article);
        void UpdateArticle(int id, ArticleDTO article);
    }
}
