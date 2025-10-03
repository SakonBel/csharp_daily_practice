// Create (simple) calculator
Operation oper = new();
oper.OperationResult();

class Operation
{
  int? firstNumber = null;
  int? secondNumber = null;
  string? oper = null;
  double? result = null;
  public void GetFirstNumber()
  {
    while (firstNumber == null)
    {
      Console.Write("Insert your first number : ");
      try
      {
        firstNumber = int.Parse(Console.ReadLine() ?? "");
      }
      catch
      {
        Console.WriteLine("First number is not a valid number");
      }
    }
  }

  public void GetSecondNumber()
  {

    while (secondNumber == null)
    {
      Console.Write("Insert your second number : ");
      try
      {
        secondNumber = int.Parse(Console.ReadLine() ?? "");
      }
      catch
      {
        Console.WriteLine("Second number is not a valid number");
      }
    }
  }

  public void UseOperator()
  {

    while (oper == null)
    {
      Console.Write("Insert operator (+,-,*,/) : ");

      oper = Console.ReadLine();
      if (oper == "+")
      {
        result = firstNumber + secondNumber;
      }
      else if (oper == "-")
      {
        result = firstNumber - secondNumber;
      }
      else if (oper == "*")
      {
        result = firstNumber * secondNumber;
      }
      else if (oper == "/")
      {
        result = (double?)firstNumber / secondNumber;
      }
      else
      {
        Console.WriteLine("Not a valid operator!");
        oper = null;
      }

    }
  }

  public void OperationResult()
  {
    GetFirstNumber();
    GetSecondNumber();
    UseOperator();
    Console.WriteLine($"Your result is : {result}");
  }
}

