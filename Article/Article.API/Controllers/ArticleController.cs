using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.DTO;
using Article.Managers.Absracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleManager _articleManager;
        public ArticleController(IArticleManager articleManager)
        {
            _articleManager = articleManager;
        }
        [HttpGet]
        public List<ArticleDTO> GetAll()
        {
            return _articleManager.GetAll();
        }

        [Route("~/api/[controller]/Get/{id}")]
        [HttpGet("{id}")]
        public ArticleDTO GetById(int id)
        {
            var article = _articleManager.GetById(id);
            if (article == null) return default(ArticleDTO);
            return article;
        }
        [Route("~/api/[controller]/AddArticle")]
        [HttpPost]
        public void InsertArticle([FromBody] ArticleDTO article)
        {
            _articleManager.AddArticle(article);
        }
        [Route("~/api/[controller]/UpdateArticle/{id}")]
        [HttpPut]
        public void UpdateArticle(int id, [FromBody] ArticleDTO article)
        {
            _articleManager.UpdateArticle(id,article);
        }
        [Route("~/api/[controller]/RemoveArticle/{id}")]
        [HttpDelete]
        public void RemoveArticle(int id)
        {
            _articleManager.RemoveArticle(id);
        }
        [Route("~/api/[controller]/search/{content}")]
        [HttpGet("{Content}")]
        public List<ArticleDTO> GetByContent(string content)
        {
            return _articleManager.GetByContent(content);
        }
    }
}
