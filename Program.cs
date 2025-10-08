// Create (simple) calculator

// Operation oper = new();
// oper.OperationResult();

// class Operation
// {
//   int? firstNumber = null;
//   int? secondNumber = null;
//   string? oper = null;
//   double? result = null;
//   public void GetFirstNumber()
//   {
//     while (firstNumber == null)
//     {
//       Console.Write("Insert your first number : ");
//       try
//       {
//         firstNumber = int.Parse(Console.ReadLine() ?? "");
//       }
//       catch
//       {
//         Console.WriteLine("First number is not a valid number");
//       }
//     }
//   }

//   public void GetSecondNumber()
//   {

//     while (secondNumber == null)
//     {
//       Console.Write("Insert your second number : ");
//       try
//       {
//         secondNumber = int.Parse(Console.ReadLine() ?? "");
//       }
//       catch
//       {
//         Console.WriteLine("Second number is not a valid number");
//       }
//     }
//   }

//   public void UseOperator()
//   {

//     while (oper == null)
//     {
//       Console.Write("Insert operator (+,-,*,/) : ");

//       oper = Console.ReadLine();
//       if (oper == "+")
//       {
//         result = firstNumber + secondNumber;
//       }
//       else if (oper == "-")
//       {
//         result = firstNumber - secondNumber;
//       }
//       else if (oper == "*")
//       {
//         result = firstNumber * secondNumber;
//       }
//       else if (oper == "/")
//       {
//         result = (double?)firstNumber / secondNumber;
//       }
//       else
//       {
//         Console.WriteLine("Not a valid operator!");
//         oper = null;
//       }

//     }
//   }

//   public void OperationResult()
//   {
//     GetFirstNumber();
//     GetSecondNumber();
//     UseOperator();
//     Console.WriteLine($"Your result is : {result}");
//   }
// }

// Create String Reverser

// ChangeString ch = new();
// ch.ReverseString();

// ChangeString.WordCounter();

// class ChangeString
// {
//   string? sentence = "";

//   public void ReverseString()
//   {
//     while (sentence == "")
//     {
//       Console.Write("Please input your string : ");
//       sentence = Console.ReadLine() ?? "";
//       if (string.IsNullOrEmpty(sentence))
//       {
//         Console.WriteLine("Please insert a valid string !!!");
//       }

//     }
//     if (sentence is not null)
//     {
//       char[] charArr = sentence.ToCharArray();
//       Array.Reverse(charArr);
//       string newString = new(charArr);
//       Console.WriteLine($"Your new string is : {newString}");
//     }
//   }

//   public static void WordCounter()
//   {
//     string? word = "";
//     while (word == "")
//     {
//       Console.Write("Please input your word : ");
//       word = Console.ReadLine() ?? "";

//       if (string.IsNullOrEmpty(word))
//       {
//         Console.WriteLine("Please in put the valid word!\n");
//       }
//     }
//     Console.WriteLine($"The word \"{word}\" has {word.Length} character!");
//   }
// }

// Create word counter

// Create area calculator


Area.TriangleArea();
class Area
{
  public static void RectangleArea()
  {
    string? width = "";
    string? height = "";

    while (width == "")
    {
      Console.Write("Please input the width(cm) : ");
      width = Console.ReadLine();

      if (string.IsNullOrEmpty(width))
      {
        Console.WriteLine("The width is invalid!!!\nPlease re-enter the valid width\n");
      }
    }

    while (height == "")
    {
      Console.Write("Please input the height(cm) : ");
      height = Console.ReadLine();
      if (string.IsNullOrEmpty(height))
      {
        Console.WriteLine("The height is invalid!!!\nPlease re-enter the valid height\n");
      }
    }

    string area = (int.Parse(width ?? "") * int.Parse(height ?? "")).ToString();

    Console.WriteLine($"Your rectangle area is : {area} cm.");
  }

  public static void TriangleArea()
  {
    string? width = "";
    string? height = "";

    while (width == "")
    {
      Console.Write("Please input the width(cm) : ");
      width = Console.ReadLine();

      if (string.IsNullOrEmpty(width))
      {
        Console.WriteLine("The width is invalid!!!\nPlease re-enter the valid width\n");
      }
    }

    while (height == "")
    {
      Console.Write("Please input the height(cm) : ");
      height = Console.ReadLine();
      if (string.IsNullOrEmpty(height))
      {
        Console.WriteLine("The height is invalid!!!\nPlease re-enter the valid height\n");
      }
    }

    string area = (int.Parse(width ?? "") * int.Parse(height ?? "") * 0.5).ToString();

    Console.WriteLine($"Your triangle area is : {area} cm.");
  }

}