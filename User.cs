﻿namespace CSTypes;

public class User
{
    public string Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, {Name} ({Email})");
    }
}
