using System.Drawing;

namespace CircusTrein_2023;

public class Wagon
{
    public List<Animal> Animals = new List<Animal>();
    public int PointsLeft = 10;

    public void TryAddAnimal(Animal animal)
    {
        if (PointsLeft < (int)animal.Size)
        {
            Console.WriteLine("Animal" + animal.Size + " " + animal.Appetite + " is too large.");
            return;
        }

        foreach (var an in Animals)
        {
            if (animal.WouldEat(an))
            {
                return;
            }
        }
        
        PointsLeft -= (int)animal.Size;
        Animals.Add(animal);
    }
}