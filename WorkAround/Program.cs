// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Person person1 = new Person();
person1.FirstName = "ENGİN";
person1.LastName = "DEMİROĞ";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 123;

Person person2=new Person();
person2.FirstName = "Murat";

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
