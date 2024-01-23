using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        
        do
        {
            Console.WriteLine("1. Arithmetic Operations");
            Console.WriteLine("2. Armstrong Numbers");
            Console.WriteLine("3. Substring of Strings");
            Console.WriteLine("4. Divide by Zero Exception");
            Console.WriteLine("5. Pascal Triangle");
            Console.WriteLine("6. Floyd's Triangle");
            Console.WriteLine("7. Read and Copy a Text File");
            Console.WriteLine("8. Stack Operations");
            Console.WriteLine("9. Complex Numbers");
            Console.WriteLine("10. Polymorphism Concepts");
            Console.WriteLine("11. Abstract Class for Calculating Perimeter");
            Console.WriteLine("12. Interface for Resizable");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    // Arithmetic Operations
                    Console.WriteLine("Arithmetic Operations selected");
                    Console.WriteLine("Enter two numbers:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Addition: " + (num1 + num2));
                    Console.WriteLine("Subtraction: " + (num1 - num2));
                    Console.WriteLine("Multiplication: " + (num1 * num2));
                    
                    if (num2 != 0)
                        Console.WriteLine("Division: " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    
                    break;
                    
                case 2:
                    // Armstrong Numbers
                    Console.WriteLine("Armstrong Numbers selected");
                    Console.WriteLine("Enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int temp = number;
                    int sum = 0;
                    
                    while (temp > 0)
                    {
                        int digit = temp % 10;
                        sum += digit * digit * digit;
                        temp /= 10;
                    }
                    
                    if (sum == number)
                        Console.WriteLine(number + " is an Armstrong number.");
                    else
                        Console.WriteLine(number + " is not an Armstrong number.");
                    
                    break;
                    
                case 3:
                    // Substring of Strings
                    Console.WriteLine("Substring of Strings selected");
                    Console.WriteLine("Enter a string: ");
                    string inputString = Console.ReadLine();
                    
                    Console.WriteLine("Enter the starting index: ");
                    int startIndex = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter the length: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    
                    if (startIndex >= 0 && startIndex + length <= inputString.Length)
                    {
                        string substring = inputString.Substring(startIndex, length);
                        Console.WriteLine("Substring: " + substring);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please check the starting index and length.");
                    }
                    
                    break;
                    
                case 4:
                    // Divide by Zero Exception
                    Console.WriteLine("Divide by Zero Exception selected");
                    Console.WriteLine("Enter two numbers: ");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    
                    try
                    {
                        int result = dividend / divisor;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    
                    break;
                    
                case 5:
                    // Pascal Triangle
                    Console.WriteLine("Pascal Triangle selected");
                    Console.WriteLine("Enter the number of rows: ");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = 0; i < rows; i++)
                    {
                        int n = 1;
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(n + " ");
                            n = n * (i - j) / (j + 1);
                        }
                        Console.WriteLine();
                    }
                    
                    break;
                    
                case 6:
                    // Floyd's Triangle
                    Console.WriteLine("Floyd's Triangle selected");
                    Console.WriteLine("Enter the number of rows: ");
                    int rowCount = Convert.ToInt32(Console.ReadLine());
                    int counter = 1;
                    
                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(counter + " ");
                            counter++;
                        }
                        Console.WriteLine();
                    }
                    
                    break;
                    
                case 7:
                    // Read and Copy a Text File
                    Console.WriteLine("Read and Copy a Text File selected");
                    Console.WriteLine("Enter the path of the source file: ");
                    string sourcePath = Console.ReadLine();
                    
                    Console.WriteLine("Enter the path of the destination file: ");
                    string destinationPath = Console.ReadLine();
                    
                    try
                    {
                        string fileContent = File.ReadAllText(sourcePath);
                        File.WriteAllText(destinationPath, fileContent);
                        Console.WriteLine("File copied successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    
                    break;
                    
                case 8:
                    // Stack Operations
                    Console.WriteLine("Stack Operations selected");
                    // Implement your stack operations here
                    break;
                    
                case 9:
                    // Complex Numbers
                    Console.WriteLine("Complex Numbers selected");
                    // Implement your complex number operations here
                    break;
                    
                case 10:
                    // Polymorphism Concepts
                    Console.WriteLine("Polymorphism Concepts selected");
                    // Implement your polymorphism concepts here
                    break;
                    
                case 11:
                    // Abstract Class for Calculating Perimeter
                    Console.WriteLine("Abstract Class for Calculating Perimeter selected");
                    // Implement your abstract class for calculating perimeter here
                    break;
                    
                case 12:
                    // Interface for Resizable
                    Console.WriteLine("Interface for Resizable selected");
                    // Implement your interface for resizable here
                    break;
                    
                case 0:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            
            Console.WriteLine();
        } while (choice != 0);
    }
}