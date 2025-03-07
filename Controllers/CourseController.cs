﻿using CorsSample.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CorsSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        [HttpGet("~/")]
        [HttpGet("GetCourses")]
        public IActionResult GetCourses()
        {
            return Ok(courseService.GetCourses());
        }
    }
}


