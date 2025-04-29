using BenchmarkDotNet.Attributes;

namespace ClassCreationBenchmarks;

[HtmlExporter]
[RPlotExporter]
[SimpleJob(id: "Class instantiation")]
public class CreatorBenchmark
{
    [Benchmark]
    public CustomerAccount CreateActivator()
    {
        return SimpleCreator<CustomerAccount>.Create();
    }

    [Benchmark]
    public CustomerAccount CreateLambda()
    {
        return  LambdaCreator<CustomerAccount>.Create();
    }
    
}