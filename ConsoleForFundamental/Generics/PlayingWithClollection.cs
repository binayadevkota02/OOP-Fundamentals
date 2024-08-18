using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC;

namespace ConsoleForFundamental.Generics;

internal class PlayingwithClollection
{
    // Arrays, lists, dictionaries

    public static void learnArray()
    {
        string[] empNames = new string[10];
        empNames[0] = "Ram";
        empNames[1] = "krishna";


        string[] names = ["ram", "shyam", "hari"];  // ctrl+K+D for formating
        byte[] evenNumbers = [2, 4, 6, 8];

        int[,] mat2 = { { 1, 2, 3 }, { 3, 4, 5 } };
        int[][] mat1 = [[2, 1, 7], [3, 4]]; // jagged arrays


        //create an  array of number from 1 to 100
        // for 
        int[] numbers = [100];
        int[] range = Enumerable.Range(1, 100).ToArray();
        foreach (int number in range)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                Console.WriteLine(number);
            }
        }




    }
    public void earnLists()
    {
        List<string> names = ["Ram", "shyam", "hari"];
        names.Add("hanuman");

        List<(string Country, string Capital)> countries = new();
        countries.Add(("Nepal", "kathmandu"));
        countries.Add(("India", "NewDelhi"));
        countries.Add(("China", "Beijing"));


        List<Person> people = new();

        Person person1 = new();
        Person person2 = new();
        Person person3 = new();
        Person person4 = new();

        people.AddRange([new Person(), person1, person2, person3, person4]);


    }

    public void LearnDictionary()
    {
        Dictionary<string, string> countries = new();
        countries.Add("Nepal", "kathmandu");
        countries.Add("India", "NewDelhi");
        countries.Add("China", "Beijing");
    }

}
