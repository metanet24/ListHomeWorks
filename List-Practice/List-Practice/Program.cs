//////using List_Practice.Models;

////////Animal animal = new Animal();

//////Fish fish = new Fish();

////////fish.Sound();

//////Bird bird = new Bird();

//////Animal Animal1 = fish;

//////Animal Animal2 = bird;

////////Bird bird1 = (Bird)animal;

//////Animal animal = bird;

//////Animal[] animals = { Animal1, Animal2, bird, fish };


//////int num1 = 5;

//////object obj = num1;

//////int num2 = (int)obj;

//////string name = "XXX";

//////obj = name;

//////string str = obj.ToString();

//////bool isMarried = (bool)obj;


//////byte num1 = 5;

//////int num2 = num1;

//////num1 =(byte) num2;

////using List_Practice.Models;

////Bird  bird = new Bird();

////Fish fish = new Fish();

////Animal animal1 = new Bird();

////Animal animal2 = new Fish();

////Object[] datas = { 1, 2, bird, "nane", fish, animal1, 100, animal2 };


////    foreach (var item in datas)
////    {
////        if(item is Animal)
////        {
////            ((Animal)item).Name = "XXX";
////            Console.WriteLine(((Animal)item).Name);
////        }
////        else
////        {
////            Console.WriteLine("no");
////        }
////    }



////foreach (var item in datas)
////{
////    Animal animal=item as Animal;
////    if (item is not null)
////    {
////        Console.WriteLine(animal.Name);
////    }
////    else
////    {
////        Console.WriteLine("no");
////    }
////}


//using List_Practice.Models;
//using System.Collections.Generic;

////List<string> list = new() { "Metanet", "Javid", "Naida" };

////for (int i = 0; i < list.Count; i++)
////{
////    Console.WriteLine(list[i]);
////}

////List<string> mails = new() { "m@mail.ru", "c@mail.ru", "b@mail.ru" };

////static void Check(string str, List<string> list)
////{
////    if (list.Contains(str))
////    {
////        Console.WriteLine("yes");
////    }
////    else
////    {
////        Console.WriteLine("no");
////    }
////}

////Check("m@mail.ru", mails);


//List<Usee> users = new();

//users.Add(new Usee{ Id=1,Name="Metanet",Age=22});
//users.Add(new Usee { Id = 2, Name = "Javid ", Age = 30 });
//users.Add(new Usee { Id = 3, Name = "Naida ", Age = 40 });


//static List<Usee> Search(string str,List<Usee>users)
//{
//    return users.Where(m=>m.Name.ToLower().Contains(str.ToLower())).ToList();
//}

//var data= Search("j", users);

//foreach(var item in data)
//{
//    Console.WriteLine(item.Name);
//}

using List_Practice.Controllers;

ProductController controller = new ProductController();

controller.GetAll();

Console.WriteLine("----------");
controller.Sort();

//controller.GetById();