Console.Write("Please input your Celsius degree : ");
string? celsiusDegree = Console.ReadLine();
int fahrenheitDegree = (Convert.ToInt32(celsiusDegree) * (9 / 5)) + 32;
Console.WriteLine($"Your temperature in Fahrenheit is {fahrenheitDegree} degree!");
