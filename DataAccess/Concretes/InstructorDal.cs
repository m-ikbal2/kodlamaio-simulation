using kodlama_io_simulation.Entities;

namespace kodlama_io_simulation.DataAccess;

public class InstructorDal : IInstructorService
{
    private List<Instructor> ınstructors;

    public InstructorDal()
    {
        Instructor ınstructor1 = new Instructor();
        ınstructor1.InstructorId = 1;
        ınstructor1.FirstName = "Engin";
        ınstructor1.LastName = "Demiroğ";
        ınstructor1.Description = "Yazılım Danışmanı";
        ınstructor1.CreateDate = DateTime.Today;

        Instructor ınstructor2 = new Instructor();
        ınstructor2.InstructorId = 2;
        ınstructor2.FirstName = "Halit Enes";
        ınstructor2.LastName = "Kalaycı";
        ınstructor2.Description = "Yazılım Mühendisi";
        ınstructor2.CreateDate = DateTime.Today;

        ınstructors = new List<Instructor> { ınstructor1, ınstructor2 };
    }

    public List<Instructor> GetAll()
    {
        return ınstructors;
    }

    public void Add(Instructor ınstructor)
    {
        ınstructors.Add(ınstructor);
    }
}