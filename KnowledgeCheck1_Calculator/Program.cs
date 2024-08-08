using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    var addNumber2 = Console.ReadLine();

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.WriteLine(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subNumber1 = Console.ReadLine();
                    var subNumber2 = Console.ReadLine();

                    if (int.TryParse(subNumber1, out int subNumOne) && int.TryParse(subNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subNumber1} - {subNumber2} = ");
                        Console.WriteLine(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    var mulNumber1 = Console.ReadLine();
                    var mulNumber2 = Console.ReadLine();

                    if (int.TryParse(mulNumber1, out int mulNumOne) && int.TryParse(mulNumber2, out int mulNumTwo))
                    {
                        Console.Write($"{mulNumber1} * {mulNumber2} = ");
                        Console.WriteLine(calculator.Multiply(mulNumOne, mulNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divNumber1 = Console.ReadLine();
                    var divNumber2 = Console.ReadLine();

                    if (int.TryParse(divNumber1, out int divNumOne) && int.TryParse(divNumber2, out int divNumTwo))
                    {
                        Console.Write($"{divNumber1} / {divNumber2} = ");
                        Console.WriteLine(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public int Divide(int numOne, int numTwo)
        {
            if (numTwo == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
            return numOne / numTwo;
        }
    }
}
