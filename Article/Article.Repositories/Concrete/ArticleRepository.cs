using Article.DataContext;
using Article.DTO;
using Article.Repositories.Absracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Article.Repositories.Concrete
{
    public class ArticleRepository : IArticleRepository
    {
        private ArticleContext _articleContext;
        public ArticleRepository(ArticleContext articleContext)
        {
            _articleContext = articleContext;
        }
        public List<ArticleDTO> GetAll()
        {
            return _articleContext.Articles.Where(x => !x.IsDeleted).Select(x => new ArticleDTO
            {
                Id = x.Id,
                AuthorId = x.AuthorId,
                CategoryId = x.CategoryId,
                Header = x.Header,
                Content = x.Content,
                KeyWord = x.KeyWord,
                AuthorName = x.Author.Name,
                AuthorSurName = x.Author.SurName,
                Email = x.Author.Email,
                PhoneNumber = x.Author.PhoneNumber,
                CategoryName = x.Category.Name,
                CreatedAt = x.CreatedAt,
                IsDeleted = x.IsDeleted
            }).ToList();
        }

        public ArticleDTO GetById(int id)
        {
            return _articleContext.Articles.Where(x => x.Id == id && !x.IsDeleted).Select(x => new ArticleDTO
            {
                Id = x.Id,
                AuthorId = x.AuthorId,
                CategoryId = x.CategoryId,
                Header = x.Header,
                Content = x.Content,
                KeyWord = x.KeyWord,
                AuthorName = x.Author.Name,
                AuthorSurName = x.Author.SurName,
                Email = x.Author.Email,
                PhoneNumber = x.Author.PhoneNumber,
                CategoryName = x.Category.Name,
                CreatedAt = x.CreatedAt,
                IsDeleted = x.IsDeleted
            }).FirstOrDefault();
        }

        public List<ArticleDTO> GetByContent(string article)
        {
            return _articleContext.Articles.Where(x => x.Content.Contains(article) && !x.IsDeleted).Select(x => new ArticleDTO
            {
                Id = x.Id,
                AuthorId = x.AuthorId,
                CategoryId = x.CategoryId,
                Header = x.Header,
                Content = x.Content,
                KeyWord = x.KeyWord,
                AuthorName = x.Author.Name,
                AuthorSurName = x.Author.SurName,
                Email = x.Author.Email,
                PhoneNumber = x.Author.PhoneNumber,
                CategoryName = x.Category.Name,
                CreatedAt = x.CreatedAt,
                IsDeleted = x.IsDeleted
            }).ToList();
        }

        public void RemoveArticle(int id)
        {
            var firstValue = _articleContext.Articles.Where(x => x.Id == id).FirstOrDefault();
            if (firstValue != null)
            {
                firstValue.IsDeleted = false;
                _articleContext.SaveChanges();
            }
        }

        public void AddArticle(ArticleDTO article)
        {
            var articleEntity = new Entities.Article();
            articleEntity.AuthorId = article.AuthorId;
            articleEntity.CategoryId = article.CategoryId;
            articleEntity.Content = article.Content;
            articleEntity.Header = article.Header;
            articleEntity.KeyWord = article.KeyWord;
            articleEntity.CreatedAt = DateTime.Now;
            articleEntity.IsDeleted = false;
            _articleContext.Articles.Add(articleEntity);
            _articleContext.SaveChanges();
        }

        public void UpdateArticle(int id, ArticleDTO article)
        {
            var articleEntity = _articleContext.Articles.Where(x => x.Id == id).FirstOrDefault();
            articleEntity.AuthorId = article.AuthorId;
            articleEntity.CategoryId = article.CategoryId;
            articleEntity.Content = article.Content;
            articleEntity.Header = article.Header;
            articleEntity.KeyWord = article.KeyWord;
            _articleContext.SaveChanges();
        }
    }
}
