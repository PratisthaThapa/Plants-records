using System;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Flower>();
for (int i = 0; i < numberOfRecords; i++)
{
  
    var flower = new Flower();

    Console.WriteLine("Enter the flower's name: ");
    flower.Name = Console.ReadLine();

    Console.WriteLine("Enter the flower's color: ");
    flower.Color = Console.ReadLine();

    recordList.Add(flower);
}

Console.WriteLine("List of flowers:");
foreach (var flower in recordList)
{
    Console.WriteLine($"Name: {flower.Name}, Color: {flower.Color}");
}

public class Plant
    {
        public string Name { get; set; }
    }
public class Flower : Plant
    {
        public string Color { get; set; }
    }

