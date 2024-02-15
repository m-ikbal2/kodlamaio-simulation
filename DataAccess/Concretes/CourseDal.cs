using kodlama_io_simulation.Entities;
using kodlama_io_simulation.Business;

namespace kodlama_io_simulation.DataAccess;

public class CourseDal : ICourseService
{
    private List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.Name = "Java";
        course1.Description = "Java 20 ile programlamaya giriş";
        course1.CourseId = 1;
        course1.Price = 1000;
        course1.CreateDate = DateTime.Today;

        Course course2 = new Course();
        course2.Name = "C#";
        course2.Description = ":Net 8.0 ile programlamaya giriş";
        course2.CourseId = 2;
        course2.Price = 1000;
        course2.CreateDate = DateTime.Today;

        courses = new List<Course> { course1, course2 };
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void DeleteById(int id)
    {
        courses.Remove(courses.FirstOrDefault(c => c.CourseId == id));
    }

    public void UpdateById(int id)
    {
        throw new NotImplementedException();
    }
}