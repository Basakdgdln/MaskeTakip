using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>
       {
           new Category{CategoryID=1, CategoryName="Kodlama" }
        };

    }

    public void CategoryAdd(Category item)
    {
        _categories.Add(item);
    }

    public void CategoryRemove(Category item)
    {
        _categories.Remove(item);
    }

    public void CategoryUpdate(Category item)
    {
        var categoryId = _categories.FirstOrDefault(x => x.CategoryID == item.CategoryID);
        if (categoryId != null)
        {
            categoryId.CategoryName = item.CategoryName;
        }
    }

    public List<Category> GetAllCategory()
    {
        foreach (var item in _categories)
        {
            Console.WriteLine(item.CategoryName);
        }
        return _categories;
    }
}
