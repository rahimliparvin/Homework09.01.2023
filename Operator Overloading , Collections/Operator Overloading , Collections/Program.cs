using Operator_Overloading___Collections.Models;
using System.Collections;


#region Kelvin-Celsius

//KelvinTemp kelvin = new KelvinTemp(273);

//CelsiusTemp Celsius = kelvin;

//Console.WriteLine(Celsius.Celsius);

#endregion

#region Author Foreach'le
//List<Author> authors = new List<Author>();

//Author author1 = new Author();

//author1.Name = "Fuad";
//author1.Surname = "Kamalov";
//author1.Age = 45;


//Author author2 = new Author();

//author2.Name = "Anar";
//author2.Surname = "Celilov";
//author2.Age = 35;

//Author author3 = new Author();

//author3.Name = "Ceylan";
//author3.Surname = "Nezerova";
//author3.Age = 51;

//Author author4 = new Author();

//author4.Name = "Sevinc";
//author4.Surname = "Abdullazade";
//author4.Age = 32;


//authors.Add(author1);
//authors.Add(author2);
//authors.Add(author3);
//authors.Add(author4);

//foreach (var item in authors)
//{
//	if (item.Age > 40)
//	{
//		Console.WriteLine(item.Name + " - " + item.Surname);
//	}
//}

#endregion

#region Author Method'la

//static List<Author> GetAllAuthor()
//{

//	List<Author> authors = new List<Author>();

//	Author author1 = new Author();

//	author1.Name = "Fuad";
//	author1.Surname = "Kamalov";
//	author1.Age = 45;


//	Author author2 = new Author();

//	author2.Name = "Anar";
//	author2.Surname = "Celilov";
//	author2.Age = 35;

//	Author author3 = new Author();

//	author3.Name = "Ceylan";
//	author3.Surname = "Nezerova";
//	author3.Age = 51;

//	Author author4 = new Author();

//	author4.Name = "Sevinc";
//	author4.Surname = "Abdullazade";
//	author4.Age = 32;


//	authors.Add(author1);
//	authors.Add(author2);
//	authors.Add(author3);
//	authors.Add(author4);

//	return authors;
//}

//GetAuthorAge();

//static void GetAuthorAge()
//{
//    var authors = GetAllAuthor();
//    foreach (var item in authors)
//    {
//        if (item.Age > 40)
//        {
//          Console.WriteLine(item.Name + " - " + item.Surname);
//        }
//    }
//}


#endregion

#region Employee Foreach'le

//	List<Employee> employees = new List<Employee>();

//	Employee emp1 = new();

//	emp1.Name = "Hafiz";
//	emp1.Surname = "Babazade";
//	emp1.Birthday = new DateTime(1989, 02, 15);
//	emp1.Salary = 1500;

//	Employee emp2 = new();

//	emp2.Name = "Besir";
//	emp2.Surname = "Abdullayev";
//	emp2.Birthday = new DateTime(1995, 06, 30);
//	emp2.Salary = 2500;

//	Employee emp3 = new();

//	emp3.Name = "Orxan";
//	emp3.Surname = "Novruzov";
//	emp3.Birthday = new DateTime(1998, 09, 06);
//	emp3.Salary = 1950;

//	Employee emp4 = new();

//	emp4.Name = "Rauf";
//	emp4.Surname = "Quliyev";
//	emp4.Birthday = new DateTime(1993, 12, 15);
//	emp4.Salary = 2200;

//	employees.Add(emp1);
//	employees.Add(emp2);
//	employees.Add(emp3);
//	employees.Add(emp4);

//	DateTime begin = new DateTime(1992, 05, 25);
//	DateTime finish = new DateTime(2001, 12, 15);

//}


//int count = 0;
//var result = 0;
//foreach (var item in employees)
//{
//	if (begin < item.Birthday && item.Birthday < finish && item.Salary > 2000)
//	{
//	    count++;
//		result = count;
//	}

//}
// Console.WriteLine(result);

#endregion

#region Employee taski Methodla

//static List<Employee> GetAllEmployees()
//{
//	List<Employee> employees = new List<Employee>();

//	Employee emp1 = new();

//	emp1.Name = "Hafiz";
//	emp1.Surname = "Babazade";
//	emp1.Birthday = new DateTime(1989, 02, 15);
//	emp1.Salary = 1500;

//	Employee emp2 = new();

//	emp2.Name = "Besir";
//	emp2.Surname = "Abdullayev";
//	emp2.Birthday = new DateTime(1995, 06, 30);
//	emp2.Salary = 2500;

//	Employee emp3 = new();

//	emp3.Name = "Orxan";
//	emp3.Surname = "Novruzov";
//	emp3.Birthday = new DateTime(1998, 09, 06);
//	emp3.Salary = 1950;

//	Employee emp4 = new();

//	emp4.Name = "Rauf";
//	emp4.Surname = "Quliyev";
//	emp4.Birthday = new DateTime(1993, 12, 15);
//	emp4.Salary = 2200;

//	employees.Add(emp1);
//	employees.Add(emp2);
//	employees.Add(emp3);
//	employees.Add(emp4);

//	return employees;
//}

//GetEmployeeCount();

//static void GetEmployeeCount()
//{
//	var employees = GetAllEmployees();

//    DateTime begin = new DateTime(1992, 05, 25);
//    DateTime finish = new DateTime(2001, 12, 15);
//	int count = 0;
//	var result = 0;

//    foreach (var item in employees)
//	{
//		if (begin < item.Birthday && item.Birthday < finish && item.Salary > 2000)
//		{
//			count++;
//			result = count;
//		}
//	}
//	Console.WriteLine(result);
//}

#endregion
