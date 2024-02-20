using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstract;

public interface ICategoryService
{
    List<Category> GetAllCategory();
    void CategoryAdd(Category item);
    void CategoryRemove(Category item);
    void CategoryUpdate(Category item);
}
