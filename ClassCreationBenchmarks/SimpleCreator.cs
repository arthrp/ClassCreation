namespace ClassCreationBenchmarks;

public class SimpleCreator<T> where T : class
{
    public static T Create()
    {
        return Activator.CreateInstance(typeof(T)) as T;
    }
}