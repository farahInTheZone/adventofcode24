using System;
using System.Diagnostics;

public class ExecutionTime {
    public static void Measure(string methodName, Action action){
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();

        Console.WriteLine($"{methodName} executed in {stopwatch.Elapsed.TotalMilliseconds * 1000}µs");
    }
}