using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstract;

public interface IInstructorService
{
    List<Instructor> GetAllInstructor();
    void InstructorAdd(Instructor item);
    void InstructorRemove(Instructor item);
    void InstructorUpdate(Instructor item);
}
