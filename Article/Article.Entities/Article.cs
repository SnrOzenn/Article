using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Article.Entities
{
    [Table("Article")]
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ArticleExplanation { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [StringLength(20)]
        public string KeyWord { get; set; }

        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
    }
}