using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Class representing a user
class User
{
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Name { get; set; }
    public int UserAge { get; set; }
}

class Program
{
    static void Main()
    {
        // Creating a list of User objects
        List<User> users = new List<User>();

        // Adding user objects to the list
        users.Add(new User { UserID = 1, UserName = "user1", Name = "John Doe", UserAge = 25 });
        users.Add(new User { UserID = 2, UserName = "user2", Name = "Jane Smith", UserAge = 30 });
        users.Add(new User { UserID = 3, UserName = "user3", Name = "Alice Johnson", UserAge = 28 });
        users.Add(new User { UserID = 4, UserName = "user4", Name = "Jim Jones", UserAge = 20 });
        users.Add(new User { UserID = 5, UserName = "user5", Name = "Mary Winz", UserAge = 40 });
        users.Add(new User { UserID = 6, UserName = "user6", Name = "Declain Mcguiniess", UserAge = 19 });
        users.Add(new User { UserID = 7, UserName = "user7", Name = "Vlad Kartosky", UserAge = 18 });
        users.Add(new User { UserID = 8, UserName = "user8", Name = "Mike Jimy", UserAge = 21 });
        users.Add(new User { UserID = 9, UserName = "user9", Name = "Legolas Murray", UserAge = 45 });




        // Iterating through the list and printing user details
        Console.WriteLine("User Details:");
        foreach (User user in users)
        {
            Console.WriteLine($"UserID: {user.UserID}, UserName: {user.UserName}, Name: {user.Name}, Age: {user.UserAge}");
        }
        // Calculating the average age using LINQ
        double averageAge = users.Average(user => user.UserAge);

        Console.WriteLine($"\nAverage Age of Users: {averageAge}");

        // Creating a new list with users under the age of 20 using LINQ
        List<User> usersUnder20 = users.Where(user => user.UserAge < 20).ToList();

        // Printing users under the age of 20
        Console.WriteLine("\nUsers under the age of 20:");
        foreach (User user in usersUnder20)
        {
            Console.WriteLine($"UserID: {user.UserID}, UserName: {user.UserName}, Name: {user.Name}, Age: {user.UserAge}");
        }

        // Counting the number of users using Count() method
        int numberOfUsers = users.Count();

        // Printing the number of users
        Console.WriteLine($"\nNumber of Users: {numberOfUsers}");

        // Creating a new list with users having odd ages using LINQ
        List<User> usersWithOddAges = users.Where(user => user.UserAge % 2 != 0).ToList();

        // Printing users with odd ages
        Console.WriteLine("\nUsers with Odd Ages:");
        foreach (User user in usersWithOddAges)
        {
            Console.WriteLine($"UserID: {user.UserID}, UserName: {user.UserName}, Name: {user.Name}, Age: {user.UserAge}");
        }

        // Selecting a random user from the list
        Random random = new Random();
        User randomUser = users[random.Next(users.Count)];

        // Printing the randomly selected user
        Console.WriteLine($"\nRandomly Selected User: UserID: {randomUser.UserID}, UserName: {randomUser.UserName}, Name: {randomUser.Name}, Age: {randomUser.UserAge}");

        // Finding the first even number in users' ages using FirstOrDefault
        int? firstEvenAge = users.Select(user => user.UserAge).FirstOrDefault(age => age % 2 == 0);

        if (firstEvenAge.HasValue)
        {
            Console.WriteLine($"\nFirst even number in users' ages: {firstEvenAge}");
        }
        else
        {
            Console.WriteLine("\nNo even number found in users' ages.");
        }

        // Check if there are any users younger than 18 using Any() operator
        bool hasUsersUnder18 = users.Any(user => user.UserAge < 18);

        if (hasUsersUnder18)
        {
            Console.WriteLine("\nThere are users younger than 18 in the list.");
        }
        else
        {
            Console.WriteLine("\nThere are no users younger than 18 in the list.");
        }

        // Function to find the minimum and maximum ages of users
        (int minAge, int maxAge) = FindMinAndMaxAges(users);

        // Printing the results
        Console.WriteLine($"\nMinimum Age: {minAge}");
        Console.WriteLine($"Maximum Age: {maxAge}");

        Console.ReadLine();
    }
    // Modular function to find the minimum and maximum ages of users
    static (int minAge, int maxAge) FindMinAndMaxAges(List<User> users)
    {
        int minAge = users.Min(user => user.UserAge);
        int maxAge = users.Max(user => user.UserAge);
        return (minAge, maxAge);
    }
}