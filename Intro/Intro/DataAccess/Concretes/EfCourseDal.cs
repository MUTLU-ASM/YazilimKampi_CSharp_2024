using Intro.DataAccess.Abstracts;
using Intro.Entities;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = ".Net 8 vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course1.Id = 2;
        course1.Name = "Java";
        course1.Description = "Java 17 ...";
        course1.Price = 10;

        Course course3 = new Course();
        course1.Id = 3;
        course1.Name = "Python";
        course1.Description = "Python 3.12 ...";
        course1.Price = 20;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //burada db ,slemleri yapilir.
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}