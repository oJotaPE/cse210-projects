using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Create create = new Create();
        
        create.GenerateRandomVideo();
    }
}