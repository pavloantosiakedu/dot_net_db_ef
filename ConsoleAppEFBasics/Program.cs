// See https://aka.ms/new-console-template for more information
using ConsoleAppEFBasics.Models;

Console.WriteLine("Simple Entity Framework app!");

using (var db = new AppDbContext())
{
    // Create
    // Add one
    db.Users.Add(
        new User()
        {
            Name = "User 1",
            Age = 19
        });

    // Add many
    db.Users.AddRange(
        new User()
        {
            Name = "User 2",
            Age = 19
        },
         new User()
         {
             Name = "User 3",
             Age = 19
         }
     );
    db.SaveChanges();

    // Read by Id
    var user = db.Users.FirstOrDefault(user => user.Id == 1);
    if (user != null)
    {
        Console.WriteLine($"User: {user.Name}, {user.Age}");
    }
    else
    {
        Console.WriteLine("User not found.");
    }

    // Read all
    foreach (var u in db.Users)
    {
        Console.WriteLine($"User: {u.Name}, {u.Age}");
    }

    // Update by id
    var user1 = db.Users.FirstOrDefault(user => user.Id == 10);
    if (user1 != null)
    {
        user1.Name = "User 2";
        user1.Age = 20;
        db.SaveChanges();
    }
    else
    {
        Console.WriteLine("User not found.");
    }

    // Delete by Id
    var user2 = db.Users.FirstOrDefault(user => user.Id == 1);
    if (user2 != null)
    {
        db.Users.Remove(user2);
        db.SaveChanges();
    }
    else
    {
        Console.WriteLine("User not found.");
    }
}


Console.WriteLine("Done.");
Console.ReadKey();
