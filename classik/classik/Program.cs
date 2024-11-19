using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        User user = new User
        {
            Name = "Андрейка",
            Email = "harvesmart@gmail.com",
            Age = 19
        };

        Console.WriteLine($"Имя: {user.Name}, Email: {user.Email}, Возраст: {user.Age}");
        Console.ReadLine(); 
    }
}

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}