using System;

//This exists to enable us to build and run this locally, without interfacing with AWS.
//We'll probably get it to call the same functions as the AWS/LambdaSharp code somehow, for local testing
namespace PrideBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
