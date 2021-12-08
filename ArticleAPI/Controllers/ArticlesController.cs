using ArticleAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        ArticleDbContext dbContext = new ArticleDbContext();

        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return dbContext.Articles;
        }

        [HttpPost]
        public IEnumerable<Article> Post(Article article)
        {
            dbContext.Add(article);
            dbContext.SaveChanges();
            return dbContext.Articles;
        }

        [HttpPut]
        public IEnumerable<Article> Put(Article article)
        {
            dbContext.Update(article);
            dbContext.SaveChanges();
            return dbContext.Articles;
        }


    }
}
