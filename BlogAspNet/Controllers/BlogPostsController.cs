using Microsoft.AspNetCore.Mvc;
using BlogAspNet.Services;

namespace BlogAspNet.Controllers;

public class BlogPostsController : Controller
{
    
    public IActionResult Index()
    {
        var blogPosts = BlogPostService.blogPosts;
        return View(blogPosts);
    }
    
    public IActionResult Details(Guid id)
    {
        var blogPosts = BlogPostService.blogPosts;
        var blogPost = blogPosts.FirstOrDefault(x => x.Id == id);
        if (blogPost == null)
        {
            return NotFound();
        }
        blogPost.Views++;

        var categoryName = CategoryService.GetCategoryById(blogPost.CategoryId)?.Name;
        
        
        ViewBag.CategoryName = categoryName ?? "Brak kategorii";
        
        return View(blogPost);
    }
}