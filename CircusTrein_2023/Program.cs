using CircusTrein_2023;

List<Wagon> Train = new List<Wagon>();
    
var generator = new Generator();
var animals = generator.GenerateAnimalList(100, new Random());
List<Animal> SmallHerbivores = new List<Animal>();
List<Animal> MediumHerbivores = new List<Animal>();
List<Animal> Largeherbivores = new List<Animal>();
int wagonCount = 1;

foreach (var animal in animals)
{
    if (animal.Appetite == Appetite.Carnivore)
    {
        continue;
    }
    switch (animal.Size)
    {
        case Size.Small:
            SmallHerbivores.Add(animal);
            break;
        case Size.Medium:
            MediumHerbivores.Add(animal);
            break;
        case Size.Large:
            Largeherbivores.Add(animal);
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
}

foreach (var carnivore in animals.Where(animal => animal.Appetite == Appetite.Carnivore))
{
    var wagon = new Wagon();
    wagon.AddAnimal(carnivore);
}

for (int j = 0; j < Train.Count; j++)
{
    var wagon = Train[j];

    if (wagon.Animals[0].Size == Size.Small && wagon.Animals[0].Appetite == Appetite.Carnivore)
    {
        switch (MediumHerbivores.Count)
        {
            case > 2:
                for (int i = 0; i < 3; i++)
                {
                    var mediumHerbivore1 = MediumHerbivores.FirstOrDefault();
                    if (mediumHerbivore1 != null)
                    {
                        wagon.AddAnimal(mediumHerbivore1);
                        MediumHerbivores.Remove(mediumHerbivore1);
                    }
                }

                Train.Add(wagon);
                break;
            case 2:
                for (int i = 0; i < 2; i++)
                {
                    var mediumHerbivore2 = MediumHerbivores.FirstOrDefault();
                    if (mediumHerbivore2 != null)
                    {
                        wagon.AddAnimal(mediumHerbivore2);
                        MediumHerbivores.Remove(mediumHerbivore2);
                    }
                }

                Train.Add(wagon);
                break;
            case 1:
                var mediumHerbivore3 = MediumHerbivores.FirstOrDefault();
                if (mediumHerbivore3 != null)
                {
                    wagon.AddAnimal(mediumHerbivore3);
                    MediumHerbivores.Remove(mediumHerbivore3);
                }

                Train.Add(wagon);
                break;
        }
    }
};

foreach (var wagon in Train.Where(wagon => wagon.Animals[0].Size == Size.Medium && wagon.Animals[0].Appetite == Appetite.Carnivore))
{
    switch (Largeherbivores.Count)
    {
        case > 2: 
            for (int i = 0; i < 3; i++)
            {
                var largeHerbivore1 = Largeherbivores.FirstOrDefault();
                if (largeHerbivore1 != null)
                {
                    wagon.AddAnimal(largeHerbivore1); 
                    MediumHerbivores.Remove(largeHerbivore1);
                }
            }
            Train.Add(wagon);
            break;
        case 2:
            for (int i = 0; i < 2; i++)
            {
                var largeHerbivore2 = Largeherbivores.FirstOrDefault();
                if (largeHerbivore2 != null)
                {
                    wagon.AddAnimal(largeHerbivore2); 
                    MediumHerbivores.Remove(largeHerbivore2);
                }
            }
            Train.Add(wagon);
            break;
        case 1: 
            var largeHerbivore3 = Largeherbivores.FirstOrDefault();
            if (largeHerbivore3 != null)
            {
                wagon.AddAnimal(largeHerbivore3);
                MediumHerbivores.Remove(largeHerbivore3);
            }
            Train.Add(wagon);
            break;
    }
};

foreach (var wagon in Train.Where(wagon => wagon.Animals[0].Size == Size.Small && wagon.Animals[0].Appetite == Appetite.Carnivore))
{
    switch (Largeherbivores.Count)
    {
        case > 2: 
            for (int i = 0; i < 3; i++)
            {
                var largeHerbivore1 = Largeherbivores.FirstOrDefault();
                if (largeHerbivore1 != null)
                {
                    wagon.AddAnimal(largeHerbivore1); 
                    MediumHerbivores.Remove(largeHerbivore1);
                }
            }
            Train.Add(wagon);
            break;
        case 2:
            for (int i = 0; i < 2; i++)
            {
                var largeHerbivore2 = Largeherbivores.FirstOrDefault();
                if (largeHerbivore2 != null)
                {
                    wagon.AddAnimal(largeHerbivore2); 
                    MediumHerbivores.Remove(largeHerbivore2);
                }
            }
            Train.Add(wagon);
            break;
        case 1: 
            var largeHerbivore3 = Largeherbivores.FirstOrDefault();
            if (largeHerbivore3 != null)
            {
                wagon.AddAnimal(largeHerbivore3);
                MediumHerbivores.Remove(largeHerbivore3);
            }
            Train.Add(wagon);
            break;
    }
};
Wagon wagon1 = new Wagon();
for (int i = 0; i < Largeherbivores.Count; i++)
{
    var largeHerbivore = Largeherbivores[i];
    if (wagon1.PointsLeft > 4)
    {
        wagon1.AddAnimal(largeHerbivore);
        Largeherbivores.Remove(largeHerbivore);
        continue;
    }

    foreach (var mediumHerbivore in MediumHerbivores)
    {
        if (wagon1.PointsLeft > 2)
        {
            wagon1.AddAnimal(mediumHerbivore);
            Largeherbivores.Remove(mediumHerbivore);
            continue;
        }

        foreach (var smallHerbivore in SmallHerbivores)
        {
            if (wagon1.PointsLeft > 0)
            {
                wagon1.AddAnimal(largeHerbivore);
                Largeherbivores.Remove(largeHerbivore);
                continue;
            }
        }
    }
    
    wagon1 = new Wagon();
    wagon1.AddAnimal(largeHerbivore);
    Largeherbivores.Remove(largeHerbivore);
}

foreach (var wagon in Train)
{
    string output = "Wagon number " + wagonCount + ": ";
    foreach (var animal in wagon.Animals)
    {
        output += animal.Size + " " + animal.Appetite + " // ";
    }
    Console.WriteLine(output);
    wagonCount += 1;
}

Console.WriteLine("\nAmount of wagons: " + Train.Count);