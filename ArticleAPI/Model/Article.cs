using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleAPI.Model
{
    [Table("article")]
    public class Article
    {
        [Column("id")]
        public int  Id { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
