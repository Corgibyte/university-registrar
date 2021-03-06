using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
    public virtual Department Department { get; set; }
    public int DepartmentId { get; set; }

    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
  }
}