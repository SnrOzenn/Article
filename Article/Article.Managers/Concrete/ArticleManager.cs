using Article.DTO;
using Article.Managers.Absracts;
using Article.Repositories.Absracts;
using System.Collections.Generic;

namespace Article.Managers.Concrete
{
    public class ArticleManager :IArticleManager
    {
        private IArticleRepository _articleRepository;
        public ArticleManager(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public List<ArticleDTO> GetAll() 
        {
            return _articleRepository.GetAll();
        }

        public List<ArticleDTO> GetByContent(string article)
        {
            return _articleRepository.GetByContent(article);
        }

        public ArticleDTO GetById(int id)
        {
            return _articleRepository.GetById(id);
        }
        public void RemoveArticle(int id)
        {
            _articleRepository.RemoveArticle(id);
        }
        public void AddArticle(ArticleDTO article)
        {
            _articleRepository.AddArticle(article);
        }

        public void UpdateArticle(int id, ArticleDTO article)
        {
            _articleRepository.UpdateArticle(id, article);
        }
    }
}