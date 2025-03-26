using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewsWeb.Pages
{
    public class IndexModel : PageModel
    {
        public Article[] Articles { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Articles = ArticlesContainer.Articles;
        }

        public async Task<PartialViewResult> OnPost(string name, string body)
        {
            ArticlesContainer.Articles = [.. ArticlesContainer.Articles, new Article
            {
                id = Math.Abs((int)DateTimeOffset.Now.Ticks),
                name  = name, 
                body = body
            }];

            Articles = ArticlesContainer.Articles;

            await Task.Delay(2000);

            return Partial("_List", Articles);
        }
    }
}
