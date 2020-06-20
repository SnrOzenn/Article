using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Article.Entities
{
    [Table("Article")]
    public class Article : Definitions
    {

        [StringLength(200)]
        public string Header { get; set; }
        public string Content { get; set; }

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