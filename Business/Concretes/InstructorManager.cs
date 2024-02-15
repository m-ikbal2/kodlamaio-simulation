using kodlama_io_simulation.DataAccess;
using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.Business.Concretes;

public class InstructorManager : IInstructorService
{
    private IInstructorService _ınstructorService;

    public InstructorManager(IInstructorService ınstructorService)
    {
        _ınstructorService = ınstructorService;
    }

    public List<Instructor> GetAll()
    {
        return _ınstructorService.GetAll();
    }

    public void Add(Instructor instructor)
    {
        Console.WriteLine("Eğitmen Başarıyla Eklendi: " + instructor.FirstName + " " + instructor.LastName);
    }
}