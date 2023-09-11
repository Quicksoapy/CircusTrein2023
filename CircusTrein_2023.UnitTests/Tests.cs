namespace CircusTrein_2023.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Generate_Animals_Correctly()
    {
        var generator = new Generator();
        var animals = generator.GenerateAnimalList(1, new Random(123));
        var expectedAnimals = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large)
        };

        Assert.That(animals[0].Appetite, Is.EqualTo(expectedAnimals[0].Appetite));
        Assert.That(animals[0].Size, Is.EqualTo(expectedAnimals[0].Size));
    }

    [Test]
    public void SortTester1()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium), 
            new Animal(Appetite.Herbivore, Size.Medium), 
            new Animal(Appetite.Herbivore, Size.Medium) 
        };
        List<Animal> smallHerbivores = new List<Animal>();
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 2);
    }
    
    [Test]
    public void SortTester2()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium), 
            new Animal(Appetite.Herbivore, Size.Medium)
        };
        List<Animal> smallHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Small),
            new Animal(Appetite.Herbivore, Size.Small),
            new Animal(Appetite.Herbivore, Size.Small),
            new Animal(Appetite.Herbivore, Size.Small),
            new Animal(Appetite.Herbivore, Size.Small),
        };
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 2);
    }
    
    [Test]
    public void SortTester3()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium)
        };
        List<Animal> smallHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Small)
        };
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Medium),
            new Animal(Appetite.Carnivore, Size.Large)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 4);
    }
    
    [Test]
    public void SortTester4()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium)
        };
        List<Animal> smallHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Small)
        };
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Medium),
            new Animal(Appetite.Carnivore, Size.Large)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 5);
    }
    
    [Test]
    public void SortTester5()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium)
        };
        List<Animal> smallHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Small)
        };
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 2);
    }
    
    [Test]
    public void SortTester6()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium)
        };
        List<Animal> smallHerbivores = new List<Animal>
        {
            
        };
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 3);
    }
    [Test]
    public void SortTester7()
    {
        var train = new Train();
        List<Animal> largeHerbivores = new List<Animal>
        {
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large),
            new Animal(Appetite.Herbivore, Size.Large)
        };
        List<Animal> mediumHerbivores = new List<Animal> 
        { 
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium),
            new Animal(Appetite.Herbivore, Size.Medium)
        };
        List<Animal> smallHerbivores = new List<Animal>
        {
           
        };
        List<Animal> carnivores = new List<Animal>
        {
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Small),
            new Animal(Appetite.Carnivore, Size.Medium),
            new Animal(Appetite.Carnivore, Size.Medium),
            new Animal(Appetite.Carnivore, Size.Medium),
            new Animal(Appetite.Carnivore, Size.Large),
            new Animal(Appetite.Carnivore, Size.Large),
            new Animal(Appetite.Carnivore, Size.Large)
        };
        var output = train.Sorter(largeHerbivores, mediumHerbivores, smallHerbivores, carnivores);
        Assert.That(output.Count == 13);
    }
}