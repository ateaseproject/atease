namespace AtEase.Extensions.DependencyInjection.Test;

public interface ISingleton
{
    string GetName();
}

public class NormalSingleton : ISingleton
{
    public string GetName()
    {
        return nameof(NormalSingleton);
    }
}

public class SingletonWithPublicCtor : ISingleton
{
    public string GetName()
    {
        return nameof(SingletonWithPublicCtor);
    }
}

public class SingletonWithStaticFactory : ISingleton
{
    private SingletonWithStaticFactory()
    {
    }

    public string GetName()
    {
        return nameof(SingletonWithStaticFactory);
    }

    public static SingletonWithStaticFactory CreateNew()
    {
        return new SingletonWithStaticFactory();
    }
}