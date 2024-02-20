// See https://aka.ms/new-console-template for more information
using KodlamaIO.Business.Concrete;
using KodlamaIO.DataAccess.Concrete;
using KodlamaIO.Entities;
using System.Net;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");


Category category= new Category() { CategoryID=2, CategoryName="Mobil Programlama"};
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.CategoryAdd(category);
categoryManager.GetAllCategory();

Console.WriteLine("------------------------------------------------------------------------");

Course course = new Course() { CourseId = 6, CourseName = "Mobil Programlama" , CourseDescription="Kursumuz her cumartesi saat 20:00 da başlayacaktır", InstructorId=1, CategoryId=2};
CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.CourseAdd(course);    
courseManager.GetAllCourse();


Console.ReadLine();