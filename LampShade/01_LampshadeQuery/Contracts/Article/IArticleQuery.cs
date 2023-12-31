using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampshadeQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> LatestArticles();
        //ArticleQueryModel GetArticleDetails(string slug);
    }
}
