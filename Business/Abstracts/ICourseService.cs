using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.DataAccess;

public interface ICourseService
{
    List<Course> GetAll();
    void Add(Course course);
    void DeleteById(int id);
    void UpdateById(int id);
}