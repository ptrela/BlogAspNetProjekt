using Microsoft.AspNetCore.Mvc;
using BlogAspNet.Services;
using BlogAspNet.Models.Entities;

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
    
    public IActionResult Edit(Guid id)
    {
        var blogPosts = BlogPostService.blogPosts;
        var blogPost = blogPosts.FirstOrDefault(x => x.Id == id);
        
        if (blogPost == null)
        {
            return NotFound();
        }

        return View(blogPost);
    }
    
    [HttpPost]
    public IActionResult Edit(BlogPost blogPost)
    {
        if (!ModelState.IsValid)
        {
            return View(blogPost);
        }

        var existingBlogPost = BlogPostService.blogPosts.FirstOrDefault(x => x.Id == blogPost.Id);
        if (existingBlogPost == null)
        {
            return NotFound();
        }

        existingBlogPost.Title = blogPost.Title;
        existingBlogPost.Content = blogPost.Content;
        existingBlogPost.CategoryId = blogPost.CategoryId;

        return RedirectToAction("Details", new { id = blogPost.Id });
    }
}