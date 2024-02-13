using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Create create = new Create();
        
        create.GenerateRandomVideo();
    }
}