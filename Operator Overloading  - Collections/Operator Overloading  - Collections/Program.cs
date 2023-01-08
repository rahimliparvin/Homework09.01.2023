// See https://aka.ms/new-console-template for more information
using Operator_Overloading____Collections.Models;
using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Net.Http.Headers;

#region Operator - Overloading

//Employee emp1 = new Employee();

//emp1.Age = 25;
//emp1.Name = "Pervin";
//emp1.Id = 1;

//Employee emp2 = new Employee();

//emp2.Age = 20;
//emp2.Name = "Saiq";
//emp2.Id = 3;

//var result = emp1 > emp2;

//Console.WriteLine(result);

#endregion

#region HashTable 
//Hashtable datas = new Hashtable();

//datas.Add(1, "Cavid");
//datas.Add(2, "Pervin");
//datas.Add(3, "Mirze");

//foreach (var item in datas.Values) // datas.Keys)
//{
//	Console.WriteLine(item);
//	Console.WriteLine(item);
//}

//foreach (DictionaryEntry item in datas)
//{
//	Console.WriteLine(item.Value + " - " + item.Key);
//}


//foreach (DictionaryEntry item in datas)
//{
//	if ((int)item.Key == 2)
//	{
//		Console.WriteLine(item.Value);
//	}
//}
#endregion

#region SortedList
//SortedList datas = new SortedList();

//datas.Add(1, "Eldar");
//datas.Add(2, "Azer");
//datas.Add(3, "Aqshin");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine(item.Value + "-" + item.Key);
//}

//SortedList -in Hashtable - dan ferqi oduki sort edende azdan coxa dogru edir ve hele yazdirir.

#endregion

#region ArrayList

//ArrayList datas = new ArrayList();

//datas.Add("Cahandar");
//datas.Add(5);
//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}
#endregion

#region List<>

//List<int> datas = new List<int>();

//datas.Add(10);
//datas.Add(40);
//datas.Add(30);
//datas.Add(15);



//datas.Sort();
//datas.Reverse();
//datas.Remove(40);

//datas.Clear();

//datas.RemoveAt(1);

//datas.RemoveAll(m => m > 20);

//foreach (var item in datas)
//{
//  Console.WriteLine(item);
//}

//datas.Sort();

//Console.WriteLine(datas[0]);

//var result = datas.Contains(30);

//Console.WriteLine(result);

//foreach (var item in datas)
//{
// Console.WriteLine(item);
//}


//List<string> names = new List<string>() { "Cavid", "Mirze", "Kamil", "Fuad", "Cavid" , "Cavid" };

//Console.WriteLine(names.Count);

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}


//foreach (var item in names)
//{
//	if (item  == "Cavid")
//	{
//     Console.WriteLine(item);
//	}

//}

//var res = names.Find(m => m == "Cavid");
//Console.WriteLine(res);

//var res = names.FindAll(m => m == "Cavid").Count;
//Console.WriteLine(res);

//foreach (var item in res)
//{
// Console.WriteLine(item);
//}


//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine(numbers.FindAll(m=> m%2==0).Sum(m=>m));


#endregion

#region Student

//List<Student> students = new();

//Student stu1 = new Student
//{
//    Id = 1,
//    FullName = "Babasov Merdan",
//    Age = 25,
//    Address = "Sumgait"

//};

//Student stu2 = new()
//{
//    Id = 2,
//    FullName = "Mirzeyeva Leyla",
//    Age = 21,
//    Address = "Baki"
//};

//Student stu3 = new()
//{
//    Id = 3,
//    FullName = "Abdullayev Besir",
//    Age = 28,
//    Address = "Gence"
//};

//Student stu4 = new()
//{
//    Id = 4,
//    FullName = "Memmedova Arife",
//    Age = 23,
//    Address = "Mingecevir"
//};

//Student stu5 = new()
//{
//    Id = 5,
//    FullName = "Babayev Sahin",
//    Age = 30,
//    Address = "Terter"
//};

//students.Add(stu1);
//students.Add(stu2);
//students.Add(stu3);
//students.Add(stu4);
//students.Add(stu5);

//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}
#endregion

#region SortedList Generic
//SortedList<int, string> datas = new SortedList<int, string>();

//datas.Add(1, "Cavid");
//datas.Add(2, "Pervin");

//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key + " - " + item.Value);
//}
#endregion

#region Stack Generic

//Stack<string> stack = new();
//stack.Push("Salam");
//stack.Push("Sagol");
//Stack<int> nums = new Stack<int>();

//nums.Push(1);
//nums.Push(2);
//nums.Push(3);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Queue Generic
//Queue<string> strings= new Queue<string>();

//strings.Enqueue("Salam");
//strings.Enqueue("Sagol");
//strings.Enqueue("XZX");

//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Dictionary Generic

//Dictionary<int, string>  datas =  new Dictionary<int, string>();

//datas.Add(1, "SuperAdmin");
//datas.Add(2, "Admin");
//datas.Add(3, "Member");

//foreach ( KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Value + " - "+ item.Key);
//}
#endregion