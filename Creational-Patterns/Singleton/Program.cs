


using Models.Singleton;

Singleton s1 = Singleton.Instance;

Singleton s2 = Singleton.Instance;

if (s1 == s2)
{
    Console.WriteLine("s1 e s2 são a mesma instância");
}
else
{
    Console.WriteLine("s1 e s2 são instâncias diferentes");
}