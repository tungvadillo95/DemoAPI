using Domain.Response.Course;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface ICourseService
    {
        IEnumerable<CourseView> Gets();
    }
}
