using System;
namespace AddressBookSystemIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\HP\Desktop\fellowShip\AddressBookSystemIO\AddressBook.txt";

            ReadAllLines(path);
        }
        public static void FileExist()
        {
            string path = @"C:\Users\HP\Desktop\fellowShip\AddressBookSystemIO\AddressBook.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }

    // IO ReadAlline UC13
    public static void ReadAllLines(string path)
        {
            string[] lines;

            lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}