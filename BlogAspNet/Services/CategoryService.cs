using BlogAspNet.Models.Entities;

namespace BlogAspNet.Services;

public class CategoryService
{
    public static List<Category> categories = new List<Category>
    {
        new Category { Id = 1, Name = "Ogólne" },
        new Category { Id = 2, Name = "Technologie" }
    };
    
    public static Category? GetCategoryById(int id)
    {
        return categories.FirstOrDefault(c => c.Id == id);
    }
}