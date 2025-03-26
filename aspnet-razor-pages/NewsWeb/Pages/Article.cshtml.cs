using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewsWeb.Pages
{
    public class ArticleModel : PageModel
    {
        public Article? Article { get; set; }

        public async Task OnGet(int id)
        {
            Article = ArticlesContainer.Articles.FirstOrDefault(x => x.id == id);
        }
    }
}
