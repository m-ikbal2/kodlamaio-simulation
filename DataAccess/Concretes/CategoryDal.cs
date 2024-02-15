using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.DataAccess;

public class CategoryDal : ICategorService
{
    private List<Category> categories;

    public CategoryDal()
    {
        Category category1 = new Category();
        category1.CategoryId = 1;
        category1.CategoryType = "Mobil Programlama";

        Category category2 = new Category();
        category2.CategoryId = 2;
        category2.CategoryType = "Web Tasarlama";

        categories = new List<Category> { category1, category2 };
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateById(int id)
    {
        throw new NotImplementedException();
    }
}