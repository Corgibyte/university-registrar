namespace Registrar.Models
{
  public class CourseStudent
  {
    public CourseStudent()
    {
      Complete = false;
    }
    public int CourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public bool Complete { get; set; }
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
  }
}