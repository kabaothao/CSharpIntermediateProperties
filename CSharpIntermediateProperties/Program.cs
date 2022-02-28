// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateProperties // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine(person.Age);
        }
    }
}

/*
What? A class member that encapsulates a getter/setter fo accessing a field.

Why?
To create a getter/setter with less code.




*/



