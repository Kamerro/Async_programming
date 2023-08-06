using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using static System.Threading.Thread;


//Declaring and starting Stopwatch
Stopwatch sw = Stopwatch.StartNew();


//Starting method that is async
var result_1 = TaskyMethod_1();
//Awaiting for all of the results:
await TaskyMethod_2();
await result_1;


sw.Stop();
Console.WriteLine($"done in {sw.ElapsedMilliseconds.ToString()} ms");




//TOTAL 3 sec of delay.
async Task<int>TaskyMethod_1()
{
    Console.WriteLine("In TaskyMethod_1");

    await Task.Delay(1000);
    return 1;
}
async Task<int> TaskyMethod_2()
{
    Console.WriteLine("In TaskyMethod_2");

    await Task.Delay(2000);
    return 2;
}