using Microsoft.AspNetCore.Mvc;
using BlogAspNet.Models.Entities;

namespace BlogAspNet.Controllers;

public class BlogPostsController : Controller
{
    private static List<BlogPost> _blogPosts = new List<BlogPost>
    {
        new BlogPost { Id = Guid.NewGuid(), Title = "Pierwszy Post", Content = "Treść pierwszego posta." },
        new BlogPost { Id = Guid.NewGuid(), Title = "Drugi post", Content = "Tresc drugiego posta." },
        new BlogPost { Id = Guid.NewGuid(), Title = "Trzeci post", Content = "Treść trzeciego posta." }
    };
    
    public IActionResult Index()
    {
        return View(_blogPosts);
    }
    
    public IActionResult Details(Guid id)
    {
        var blogPost = _blogPosts.FirstOrDefault(x => x.Id == id);
        if (blogPost == null)
        {
            return NotFound();
        }
        return View(blogPost);
    }
}