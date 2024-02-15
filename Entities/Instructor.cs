namespace kodlama_io_simulation.Entities;

public class Instructor : BaseEntity
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
}