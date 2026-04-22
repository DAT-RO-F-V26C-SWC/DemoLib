// See https://aka.ms/new-console-template for more information
using DemoLib.model;

Console.WriteLine("Hello, World!");

Person p = new Person("Peter", "pele@zealand.dk");

Console.WriteLine(p);

ProductOwner po = new ProductOwner("Vibeke", "visa@zealand.dk", "Zealand");

Console.WriteLine(po);

po.Email = "hhhhh";