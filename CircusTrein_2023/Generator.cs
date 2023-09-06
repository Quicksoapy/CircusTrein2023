namespace CircusTrein_2023;

public class Generator
{
    public List<Animal> GenerateAnimalList(int iterations, Random rand)
    {
        List<Animal> output = new List<Animal>();
        for (int i = 0; i < iterations; i++)
        {
            Appetite[] appetites = (Appetite[])Enum.GetValuesAsUnderlyingType(typeof(Appetite));
            Size[] sizes = (Size[])Enum.GetValuesAsUnderlyingType(typeof(Size));

            output.Add(new Animal(appetites[rand.Next(0, 2)], sizes[rand.Next(0, 3)]));
        }
        return output;
    }
}