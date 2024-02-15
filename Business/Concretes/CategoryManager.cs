using kodlama_io_simulation.DataAccess;
using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.Business.Concretes;

public class CategoryManager : ICategorService
{
    private ICategorService _categorService;

    public CategoryManager(ICategorService categorService)
    {
        _categorService = categorService;
    }

    public List<Category> GetAll()
    {
        return _categorService.GetAll();
    }

    public void Add(Category category)
    {
        _categorService.Add(category);
    }

    public void DeleteById(int id)
    {
        _categorService.DeleteById(2);
    }

    public void UpdateById(int id)
    {
        _categorService.UpdateById(5);
    }
}