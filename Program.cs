Console.Write("Tell me your name : ");
string? userName = Console.ReadLine();
Console.Write("How old are you : ");
int? userAge = int.Parse(Console.ReadLine());


Console.WriteLine($"Hello, {userName}! \nYou are {userAge} years old and can access our program.");
