using CorsSample.IRepositories;
using CorsSample.IServices;
using CorsSample.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CorsSample.Services
{
   
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        List<Course> courseList;
        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public List<Course> GetCourses()
        {
            return courseRepository.GetCourses();
        }

    }
}
