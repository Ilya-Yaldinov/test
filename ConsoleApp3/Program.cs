using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Amimal amimal = new Amimal();
        Amimal an = new Cat();
        Cat cat = new Cat();
        
        
        amimal.Speak();
        an.Speak();
        cat.Speak();
        string str = "Hello World";
        char c = 'o';
        int count = str.CharCount(c);
        Console.WriteLine(count);
    }
}

public class Car : IEquatable<Car>
{
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    public bool Equals(Car car)
    {
        return this.Model == car.Model &&
               this.Make == car.Make &&
               this.Year == car.Year;
    }
}

public static class StringExtension
{
    public static int CharCount(this string str, char c)
    {
        int count = 0;
        for (int k = 0; k < str.Length; k++)
        {
            if (str[k] == c)
            {
                count++;
            }
        }
        return count;
    }
}

public class Amimal
{
    public virtual void Speak()
    {
        Console.WriteLine("я существую");
    }
}

public class Cat : Amimal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}