using CircusTrein_2023;

var train = new Train();
var generator = new Generator();
var animals = generator.GenerateAnimalList(100, new Random());

List<Animal> herbivores = new List<Animal>();
List<Animal> carnivores = new List<Animal>();
int wagonCount = 1;

foreach (var animal in animals)
{
    if (animal.Appetite == Appetite.Carnivore)
    {
        carnivores.Add(animal);
        continue;
    }
    herbivores.Add(animal);
    /*
    switch (animal.Size)
    {
        case Size.Small:
            SmallHerbivores.Add(animal);
            break;
        case Size.Medium:
            MediumHerbivores.Add(animal);
            break;
        case Size.Large:
            LargeHerbivores.Add(animal);
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
    */
}

var wagons = train.Sorter(herbivores, carnivores);

foreach (var wagon in wagons)
{
    string output = "Wagon number " + wagonCount + ": ";
    foreach (var animal in wagon.Animals)
    {
        output += animal.Size + " " + animal.Appetite + " // ";
    }
    Console.WriteLine(output);
    wagonCount += 1;
}

Console.WriteLine("\nAmount of wagons: " + wagons.Count);