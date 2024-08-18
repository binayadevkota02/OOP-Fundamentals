using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForFundamental;

internal class ParallelAndAsync
{
    //parallel programming : ability to compute task simultaneously in multiple CPU cores
    //.NET - TPL = Task Parallel Library
    // Task, Task<> class

    int[] numbers = [1, 45, 84, 456, 2663, 76886];
    public void ComputeSequential()
    {
        Console.WriteLine("computing in Sequence:");
        foreach (int number in numbers)
            ComputeIfPrime(number);

    }

    public void ComputeParallel()
    {
        Console.WriteLine("computing in Parallel:");
        Parallel.ForEach(numbers, x =>
        ComputeIfPrime(x)
        );

    }


    private void ComputeIfPrime(int num)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"computing {num}.....it's done");
    }


    //asynchronus programmingc: doing thing in background in non-bloking way
    // async and await 

    public async Task DoTask1()
    {
        await Task.Delay(1000);
    }

    public async Task<string> DoTask2()
    {
       HttpClient client = new HttpClient();
        var homePageContent = await client.GetStringAsync("https://appsoft.edu.np/");
        return homePageContent;

    }


}
