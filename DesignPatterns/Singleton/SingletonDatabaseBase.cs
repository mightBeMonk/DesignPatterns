using MoreLinq;

public sealed class SingletonDatabaseBase:IDatabase
{
    private Dictionary<string, int> capitals;

    //Make constructor private
    private SingletonDatabaseBase()
    {
        Console.WriteLine("Initializing database");

        capitals = File.ReadAllLines("capitals.txt").Batch(2).ToDictionary(list => list.ElementAt(0).Trim(), list => int.Parse(list.ElementAt(1)));
    }

    // Create oject internally as static and Lazily.
    private static Lazy<SingletonDatabaseBase> instance = new Lazy<SingletonDatabaseBase>(()=>new SingletonDatabaseBase());

    //Expose that instance through a public method.
    public static SingletonDatabaseBase Instance() {
        return instance.Value;
    }
    public int GetPolpulation(string name)
    {
        return capitals[name];
    }
}