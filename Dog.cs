using System;
using System.Collections.Generic;
using System.Linq;

public class Dog
{
    public string Breed { get; set; }
    public string Owner { get; set; }
    public string Name { get; set; }
    public double Weight { get; set; }

    public Dog(string breed, string owner, string name, double weight)
    {
        Breed = breed;
        Owner = owner;
        Name = name;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"Breed: {Breed}, Owner: {Owner}, Name: {Name}, Weight: {Weight}";
    }
}