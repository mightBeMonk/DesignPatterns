// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Hosting;

var db =  SingletonDatabaseBase.Instance();
var city = "Delhi";
Console.WriteLine(value: $"{city} has population {db.GetPolpulation(city)}");
Console.ReadLine();
