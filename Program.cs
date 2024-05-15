using System.IO;

class Program
{
    static void Main()
    {
        // Specify the file path
        string filePath = "hello.txt";

        // Write "Hello, World!" to the file
        File.WriteAllText(filePath, "Hello, World!");
    }
}
