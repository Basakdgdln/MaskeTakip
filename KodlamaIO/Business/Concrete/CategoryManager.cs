using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void CategoryAdd(Category item)
    {
        _categoryDal.CategoryAdd(item);
    }

    public void CategoryRemove(Category item)
    {
       _categoryDal.CategoryRemove(item);
    }

    public void CategoryUpdate(Category item)
    {
        _categoryDal.CategoryUpdate(item);
    }

    public List<Category> GetAllCategory()
    {
        return _categoryDal.GetAllCategory();
    }
}
