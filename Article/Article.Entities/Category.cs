using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Article.Entities
{
    [Table("Category")]
    public class Category : Definitions
    {
        [StringLength(50)]
        public string Name { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}