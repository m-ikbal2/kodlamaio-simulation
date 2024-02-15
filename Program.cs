using kodlama_io_simulation.Business;
using kodlama_io_simulation.Business.Concretes;
using kodlama_io_simulation.DataAccess;
using kodlama_io_simulation.Entities;

InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
List<Instructor> ınstructors = ınstructorManager.GetAll();

foreach (Instructor ınstructorDal in ınstructors)
{
    Console.WriteLine(ınstructorDal.FirstName + " " + ınstructorDal.LastName + " / " + ınstructorDal.CreateDate.Day);
}

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

foreach (Course courseDal in courses)
{
    Console.WriteLine(courseDal.Name + " / " + courseDal.Description + " / " + courseDal.CreateDate.Day + " / " +
                      courseDal.Price);
}

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

foreach (Category categoryDal in categories)
{
    Console.WriteLine(categoryDal.CategoryType + " / " + categoryDal.CreateDate);
}