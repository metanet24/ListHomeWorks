using List_Practice.Controllers;
using List_Practice.Models;
using System.Globalization;

//Animal animal = new Animal();
//Fish fish = new Fish();

//Bird bird = new Bird();


//fish.Sound();

//Animal animal2 = fish;

//Animal animal3 = bird; //bu adlanir upcasting

//Bird bird1 = (Bird)animal;

//Animal[] datas = { animal, bird, animal3 };
//foreach (var item in datas)
//{
//    item.Name = "xxx";

//    Console.WriteLine(item.Name);
//}

//int num1 = 5;
//object obj = num1;
////int num2 = obj;
//int num2 =(int)obj;

//bool isMarried=false;

//object data = isMarried;

//bool test = (bool)data;

//string name = "test";
//object data2 = name;

//string name2 =data2.ToString();

//byte num=5;
//int num4 = num;

//int num2 = 3;

//byte num3 =(byte)num2;

//Bird bird = new Bird();

//Fish fish = new Fish();

//Animal animal1 = new Bird();

//Animal animal2 = new Fish();

//object[] datas = { 1, 2, bird, "salam", fish, animal1, 100, animal2 };

//foreach (var data in datas)
//{
//    ((Animal)data).Name = "xxx";
////    Console.WriteLine(data);
////}
//foreach (var data in datas)

//{ if (data is Animal t)
//    {
//        (t.Name = "xxx";
//        Console.WriteLine(t.name);
//    }
//    else
//    {
//        Console.WriteLine($"{data} cannot cast");
//    }
////    }


//foreach (var data in datas)
//{
//    Animal animal =data as Animal;

//    if(animal != null)
//    {
//        Console.WriteLine(animal.Name);
//    }
////}


//List<int> nums = new List<int>();
//List<int> nums2 = new List<int>();

//nums2.Add(100);
//nums2.Add(200);
//nums.AddRange(nums2);

//nums.Add(1);
//nums.Add(2);
//nums.Add(3);
//nums.Add(4);
//Console.WriteLine(nums[2]);
//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(nums.Count);


//List<string> names = new List<string>() { "Tunzale", "Metanet", "Cavid" };
//List<string> names = new() { "Tunzale", "Metanet", "Cavid" };

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//List<string> emails = new() { "test@mail.ru", "test12@mail.ru", "metish@mail.ru" };

//static void CheckEmail(string email,List<string> emails)
//{
//    if (emails.Contains(email))
//    {
//        Console.WriteLine("yes");
//    }
//    else
//    {
//        Console.WriteLine("no");
//    }
//}

//CheckEmail("metish@mail.ru", emails);


//List<Product> products = new() { new Product { Id = 1, Name = "iphone" }, new Product { Id = 2, Name = "iphone" }, new Product { Id = 3, Name = "iphone" } };
//foreach (var item in products)
//{
//    Console.WriteLine(item.Name);
//}

//static List<Product>Search(string str, List<Product>products)
//{

//    //var datas=products.FindAll(x => x.Name.Contains(str));

//    return products.Where(m=>m.Name.Contains(str)).ToList();

//}

//List<int> numbers = new() { 1, 2, 3, 4, 5 };

//for (int i = 0; i < numbers.Count; i++)
//{
//    if (i <= 4)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//for (int i = 0; i < numbers.Count; i++)
//{
//    if (numbers[i] == 5)
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}


//for (int i = 0; i < numbers.Count; i++)
//{
//    int index=numbers.IndexOf(5);

//    if (i <= index)
//    {
//        Console.WriteLine(numbers[i]);
//    }

//}


ProductController productController = new ProductController();

//productController.GetById(2);

//productController.GetAll();
//productController.Sort();