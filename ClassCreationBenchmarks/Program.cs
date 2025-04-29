using BenchmarkDotNet.Running;

namespace ClassCreationBenchmarks;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<CreatorBenchmark>();
    }
}