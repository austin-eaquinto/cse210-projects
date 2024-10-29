using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        Address address = new Address("Trejo Street", "Rexburg", "Idaho", "USA");
        Console.WriteLine(address.CustomerAddress());
    }
}