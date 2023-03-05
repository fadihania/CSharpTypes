namespace CSTypes;

public class User
{
    public User(string id) => Id = id;

    public string Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public static string Seed = "ei723jhrkdyf983";

    public void Print() => Console.WriteLine($"ID: {Id}, {Name} ({Email})");
}
