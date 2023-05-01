using ExerciseGetHashCodeEquals.Entities;

Client a = new Client { Name = "thiago", Email = "thiago.ads.silva@gmail.com"};
Client b = new Client { Name = "thiago", Email = "thiago.ads.silva@gmail.com" };

Console.WriteLine(a.Equals(b));

Console.WriteLine();

if (a.GetHashCode() == b.GetHashCode())
{
    Console.WriteLine("São iguais");
}
else {
    Console.WriteLine("São diferentes");
}

