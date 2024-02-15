using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.DataAccess;

public interface IInstructorService
{
    List<Instructor> GetAll();
    void Add(Instructor ınstructor);
}