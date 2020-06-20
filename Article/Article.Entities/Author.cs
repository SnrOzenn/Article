using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Article.Entities
{
    [Table("Author")]
    public class Author: Definitions
    {

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string SurName { get; set; }

        [StringLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(11), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}