using SneakerSpot.Models;
using SneakerSpot.Repositories;
using SneakerSpot.Services;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Създаваме инстанция на репозитория и услугата
        ISneakerRepository sneakerRepository = new SneakerRepository();
        SneakerService sneakerService = new SneakerService(sneakerRepository);

        // Добавяме примерни маратонки в репозитория
        var sneakersToAdd = new List<Sneaker>
        {
            new Sneaker { Id = 1, Name = "Air Max", Price = 199.99M, Brand = "Nike" },
            new Sneaker { Id = 2, Name = "Classic", Price = 99.99M, Brand = "Reebok" }
        };

        foreach (var sneaker in sneakersToAdd)
        {
            sneakerRepository.Add(sneaker);
        }

        // Извеждаме всички маратонки на екрана
        Console.WriteLine("Available Sneakers:");
        foreach (var sneaker in sneakerService.GetAllSneakers())
        {
            Console.WriteLine($"ID: {sneaker.Id}, Name: {sneaker.Name}, Price: {sneaker.Price}, Brand: {sneaker.Brand}");
        }
    }
}
