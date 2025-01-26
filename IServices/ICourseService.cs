using CorsSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorsSample.IServices
{
    public interface ICourseService
    {
        public List<Course> GetCourses();
    }
}
