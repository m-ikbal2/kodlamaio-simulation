namespace kodlama_io_simulation.Entities;

public class Course : BaseEntity
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public double Price { get; set; }
}