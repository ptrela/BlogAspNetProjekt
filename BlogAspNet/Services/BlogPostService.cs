using BlogAspNet.Models.Entities;

namespace BlogAspNet.Services;

public class BlogPostService
{
    public static List<BlogPost> blogPosts = new List<BlogPost>
    {
        new BlogPost { Id = Guid.NewGuid(), Title = "Pierwszy Post", Content = "Treść pierwszego posta.", Views = 0, CategoryId = 1 },
        new BlogPost { Id = Guid.NewGuid(), Title = "Drugi post", Content = "Tresc drugiego posta.", Views = 3, CategoryId = 2 },
        new BlogPost { Id = Guid.NewGuid(), Title = "Trzeci post", Content = "Treść trzeciego posta.", Views = 5, CategoryId = 2 }
    };
}