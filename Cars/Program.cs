// See https://aka.ms/new-console-template for more information
using Cars;

Seat seat = new Seat("FA19", "Red");
Tesla tesla = new Tesla("E-175", "Silver", "300");
Console.WriteLine(seat.Start());
Console.WriteLine(seat.Stop());
Console.WriteLine(tesla.Start());
Console.WriteLine(tesla.Stop());