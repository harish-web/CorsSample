using CorsSample.IRepositories;
using CorsSample.Models;

namespace CorsSample.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        List<Course> courseList;
        public CourseRepository()
        {
            courseList = new List<Course>
            {
                new Course { Id =1, Name ="AZ204" },
                new Course { Id =2, Name ="AZ204" },
                new Course { Id = 3, Name = "AZ204" },
                new Course { Id = 4, Name = "AZ204" }
            };
        }
        public List<Course> GetCourses()
        {
            return courseList;  
        }
    }
}
