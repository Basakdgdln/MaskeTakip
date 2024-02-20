using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void CourseAdd(Course item)
    {
        _courseDal.CourseAdd(item);
    }

    public void CourseRemove(Course item)
    {
       _courseDal.CourseRemove(item);
    }

    public void CourseUpdate(Course item)
    {
        _courseDal.CourseUpdate(item);  
    }

    public List<Course> GetAllCourse()
    {
        return _courseDal.GetAllCourse();
    }
}
