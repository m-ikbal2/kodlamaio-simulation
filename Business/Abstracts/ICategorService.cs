using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.DataAccess;

public interface ICategorService
{
    List<Category> GetAll();
    void Add(Category category);
    void DeleteById(int id);
    void UpdateById(int id);
}