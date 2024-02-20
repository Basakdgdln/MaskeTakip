using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _ınstructorDal;
    public InstructorManager(IInstructorDal ınstructorDal)
    {
        _ınstructorDal = ınstructorDal;
    }

    public List<Instructor> GetAllInstructor()
    {
        return _ınstructorDal.GetAllInstructor();
    }

    public void InstructorAdd(Instructor item)
    {
        _ınstructorDal.InstructorAdd(item);
    }

    public void InstructorRemove(Instructor item)
    {
        _ınstructorDal.InstructorRemove(item);
    }

    public void InstructorUpdate(Instructor item)
    {
        _ınstructorDal.InstructorUpdate(item);
    }
}
