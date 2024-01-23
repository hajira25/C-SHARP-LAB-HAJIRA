using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the source file path: ");
        string sourceFile = Console.ReadLine(); // User input for source file path

        Console.Write("Enter the destination file path: ");
        string destinationFile = Console.ReadLine(); // User input for destination file path

        try
        {
            // Ensure that the target does not exist.
            if (File.Exists(destinationFile))
            {
                File.Delete(destinationFile);
            }

            // Copy the file.
            File.Copy(sourceFile, destinationFile);
            Console.WriteLine("{0} was copied to {1}.", sourceFile, destinationFile);

            // Check if file exists at the new location
            if (File.Exists(destinationFile))
            {
                Console.WriteLine("The file has been successfully copied to the destination.");
            }
            else
            {
                Console.WriteLine("The file could not be copied.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}
