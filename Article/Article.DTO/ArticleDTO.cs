using System;
using System.ComponentModel.DataAnnotations;

namespace Article.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Header { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public int AuthorId { get; set; }

        [StringLength(20)]
        public string KeyWord { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        [StringLength(50)]
        public string AuthorSurName { get; set; }

        [StringLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(11), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}