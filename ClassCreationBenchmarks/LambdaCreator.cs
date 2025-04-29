using System.Linq.Expressions;

namespace ClassCreationBenchmarks;

public class LambdaCreator<T> where T : class
{
    public static readonly Func<T> Create = BuildFactory();

    private static Func<T> BuildFactory()
    {
        NewExpression newExp = Expression.New(typeof(T));
        
        Expression<Func<T>> lambda = Expression.Lambda<Func<T>>(newExp);
        
        return lambda.Compile();
    }
}