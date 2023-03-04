using CSTypes;

Console.WriteLine(User.Seed);


var u1 = new User();
User u2;

// Private member, cannot access
//u1.id = "kf938k237sl";

//u1.SetName("Ahmad");
//Console.WriteLine(u1.GetName());

u1.Name = "Ahmad";
Console.WriteLine(u1.Name);

u1.Email = "ahmad@example.com";

u1.Print();