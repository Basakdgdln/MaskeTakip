using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAllCourse();
    void CourseAdd(Course item);
    void CourseRemove(Course item);
    void CourseUpdate(Course item);
}
