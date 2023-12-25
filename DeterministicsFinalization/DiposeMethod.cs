using System;
using System.Collections.Generic;
namespace disposetest;


public class ResourceHolder : IDisposable
{
    private List<string> resources = new List<string>();

    public void AddResource(string resource)
    {
        resources.Add(resource);
    }

    public void Dispose()
    {
        foreach (string resource in resources)
        {
            Console.WriteLine("Releasing resource: " + resource);
        }
        Dispose(false);
        resources.Clear();
    }

    ~ResourceHolder()
    {
        Console.WriteLine("IN Destructors");
        Dispose(false);
    }

    protected virtual void Dispose(bool disposed)
    {
        if (!disposed)
        {
            //Console.WriteLine("IN Dispose Method");
            if (disposed)
            {
                // Release managed resources

                Console.WriteLine("Relesed manage resources");
            }
            else
            {
                // Release unmanaged resources

                Console.WriteLine("Relesed unmanage resources");
            }
            Dispose(true);
        }
    }
}