using System;
using System.Collections.Generic;
namespace dotnet_IndexOutOfRangeException
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int value1 = int.Parse(Console.ReadLine());
                List<char> characters = new List<char>();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'f'});
                int value = characters[value1];
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
