using CSTypes;

// Value type
int x = 5;
int y = x;
Console.WriteLine(x); // => 5
Console.WriteLine(y); // => 5

x = 10;
Console.WriteLine(x); // => 10
Console.WriteLine(y); // => 5


// Reference type
var u1 = new User();
User u2 = u1;

u1.Name = "Ahmad";
Console.WriteLine(u1.Name); // => Ahmad
Console.WriteLine(u2.Name); // => Ahmad

u1.Name = "Majed";
Console.WriteLine(u1.Name); // => Majed
Console.WriteLine(u2.Name); // => Majed

u1.Email = "ahmad@example.com";

u1.Print();