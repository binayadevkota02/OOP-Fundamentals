using ABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForFundamental.FileIO;

internal class FileHandler
{
    public async Task<List<Person>> ReadFileAsync()
    {
        string filePath = @"C:\Users\binaya.raj_teksewa\Desktop\OOP fundamental\OOP-Fundamentals\ConsoleForFundamental\FileIO\Files\Employees.csv";
        //@ verbating character 
        var fileContent = await File.ReadAllTextAsync(filePath);
        //Console.WriteLine(fileContent);

        //Display name and dob of all people in employee.csv
        var lines = fileContent.Split(["\n", "\r"], StringSplitOptions.RemoveEmptyEntries);

        var employees = new List<Person>();
        foreach (var line in lines.Skip(1))
        {
            var data = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var name = data[0];
            DateTime.TryParse(data[1], out DateTime d);
            var dob = d;
            var nid = long.Parse(data[2]);

            var employee = new Person(name, dob, nid);
            employees.Add(employee);
        }

        Console.WriteLine("===========================");
        foreach (var emp in employees)
        {
            emp.PrintDetails();
            Console.WriteLine();
        }
        Console.WriteLine("===========================");
        return employees;
        // Console.WriteLine(lines.Length);

    }

    public async Task WriteFileAsync()
    {
        string filePath = @"C:\Users\binaya.raj_teksewa\Desktop\OOP fundamental\OOP-Fundamentals\ConsoleForFundamental\FileIO\Files\People.txt";

       await File.WriteAllTextAsync(filePath, "This file contains info about people\n people's data ");
    }

    public async Task  WriteEmployeesToFileAsync(List<Person>employees)
    {
        string filePath = @"C:\Users\binaya.raj_teksewa\Desktop\OOP fundamental\OOP-Fundamentals\ConsoleForFundamental\FileIO\Files\Employees.txt";
        var employeeCollection = employees.Select(Person.PrintDetails);
        await File.WriteAllLinesAsync(filePath, employeeCollection);


    }

    public void GetFileInfo()
    {
        string filePath = @"C:\Users\binaya.raj_teksewa\Desktop\OOP fundamental\OOP-Fundamentals\ConsoleForFundamental\FileIO\Files\Employees.txt";
        FileInfo fileInfo = new FileInfo(filePath); 
        Console.WriteLine(fileInfo.FullName);
        Console.WriteLine(fileInfo.CreationTime);
        Console.WriteLine(fileInfo.LastAccessTime);
        Console.WriteLine($"{fileInfo.Length / 1024 : F2} KB");

    }

}
