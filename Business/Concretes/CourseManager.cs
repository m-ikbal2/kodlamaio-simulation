using kodlama_io_simulation.DataAccess;
using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.Business;

public class CourseManager : ICourseService
{
    private readonly ICourseService _courseService;

    public CourseManager(ICourseService courseService)
    {
        _courseService = courseService;
    }

    public List<Course> GetAll()
    {
        return _courseService.GetAll();
    }

    public void Add(Course course)
    {
        _courseService.Add(course);
    }

    public void DeleteById(int id)
    {
        _courseService.DeleteById(10);
    }

    public void UpdateById(int id)
    {
        _courseService.UpdateById(14);
    }
}