using System; 

class URI {

    static void Main(string[] args) { 

        double raio = double.Parse(Console.ReadLine());

        double pi = 3.14159;

        double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {volume:F3}");

    }

}