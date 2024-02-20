using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAllInstructor();
    void InstructorAdd(Instructor item);
    void InstructorRemove(Instructor item);
    void InstructorUpdate(Instructor item);
}
