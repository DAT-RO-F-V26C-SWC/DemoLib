// See https://aka.ms/new-console-template for more information
using DemoLib.model;

Console.WriteLine("Hello, World!");

Person p = new Person("Peter", "pele@zealand.dk");

Console.WriteLine(p.Salery());

ProductOwner po = new ProductOwner("Vibeke", "visa@zealand.dk", "Zealand");

Console.WriteLine(po.Salery());



Person ppo = po;
Console.WriteLine(ppo.Salery());


