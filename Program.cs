using CSTypes;
using CSTypes.Records;

// Class object
var u1 = new User("kdjf93487jdhf")
{
    Name = "Ahmad",
    Email = "ahmad@example.com"
};

var u2 = new User("kdjf93487jdhf")
{
    Name = "Ahmad",
    Email = "ahmad@example.com"
};

Console.WriteLine(u1); // Prints object type

if (u1 == u2) // Compares references
    Console.WriteLine("u1 & u2 are equal");
else
    Console.WriteLine("u1 & u2 not equal");

Console.WriteLine();


// Record object
var p1 = new Post("23kdfh8374", "Post 1", "Post 1 content", u1.Id);
var p2 = new Post("23kdfh8374", "Post 1", "Post 1 content", u1.Id);

Console.WriteLine(p1); // Prints object type and data

if (p1 == p2) // Compare values
    Console.WriteLine("p1 & p2 are equal");
else
    Console.WriteLine("p1 & p2 not equal");

