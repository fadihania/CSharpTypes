
using CSTypes;

var u1 = new User();
User u2;

// Private member, cannot access
//u1.id = "kf938k237sl";

u1.SetName("Ahmad");
Console.WriteLine(u1.GetName());