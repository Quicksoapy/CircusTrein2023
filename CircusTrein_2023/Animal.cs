namespace CircusTrein_2023;

public class Animal
{
    public Appetite Appetite;
    public Size Size;
    
    public Animal(Appetite appetite, Size size)
    {
        Appetite = appetite;
        Size = size;
    }

    //TODO check if food here in animal?
    public bool WouldEat(Animal animal)
    {
        if (Appetite == Appetite.Herbivore)
        {
            return false;
        }

        if (animal.Size > Size)
        {
            return false;
        }
        
        Console.WriteLine("Animal " + Size + " " + Appetite + " would eat " + animal.Size + " " + animal.Appetite);

        return true;
    }
}