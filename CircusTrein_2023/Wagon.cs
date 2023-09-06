using System.Drawing;

namespace CircusTrein_2023;

public class Wagon
{
    public List<Animal> Animals = new List<Animal>();
    public int PointsLeft = 10;

    public void AddAnimal(Animal animal)
    {
        if (PointsLeft < (int)animal.Size)
        {
            Console.WriteLine("Animal" + animal.Size + " "+ animal.Appetite + " is too large.");
            return;
        }

        if (animal.Appetite == Appetite.Carnivore)
        {
            foreach (var obj in Animals)
            {
                if (obj.Size > animal.Size) continue;
                Console.WriteLine("Animal" + animal.Size + " "+ animal.Appetite + " is carnivore and not all animals are bigger.");
                return;
            }
        }

        PointsLeft -= (int)animal.Size;
        Animals.Add(animal);
    }
}