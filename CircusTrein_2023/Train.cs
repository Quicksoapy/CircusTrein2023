namespace CircusTrein_2023;

public class Train
{
    private List<Wagon> wagons = new List<Wagon>();
    public List<Wagon> Sorter(List<Animal> LargeHerbivores, List<Animal> MediumHerbivores, List<Animal> SmallHerbivores, List<Animal> Carnivores)
    {
        foreach (var carnivore in Carnivores)
        {
            var wagon = new Wagon();
            wagon.AddAnimal(carnivore);
            wagons.Add(wagon);
        }

        for (int j = 0; j < wagons.Count; j++)
        {
            var wagon = wagons[j];

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

                        wagons.Add(wagon);
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

                        wagons.Add(wagon);
                        break;
                    case 1:
                        var mediumHerbivore3 = MediumHerbivores.FirstOrDefault();
                        if (mediumHerbivore3 != null)
                        {
                            wagon.AddAnimal(mediumHerbivore3);
                            MediumHerbivores.Remove(mediumHerbivore3);
                        }

                        wagons.Add(wagon);
                        break;
                }
            }
        };


        for (int j = 0; j < wagons.Count; j++)
        {
            var wagon = wagons[j];

            if (wagon.Animals[0].Size == Size.Medium && wagon.Animals[0].Appetite == Appetite.Carnivore && wagon.PointsLeft > 4)
            {
                var largeHerbivore = LargeHerbivores.FirstOrDefault();
                if (largeHerbivore != null)
                {
                    wagon.AddAnimal(largeHerbivore);
                    MediumHerbivores.Remove(largeHerbivore);
                }

                wagons.Add(wagon);
            }
        };


        for (int j = 0; j < wagons.Count; j++)
        {
            var wagon = wagons[j];

            if (wagon.Animals[0].Size == Size.Small && wagon.Animals[0].Appetite == Appetite.Carnivore && wagon.PointsLeft > 4)
            {
                var largeHerbivore = LargeHerbivores.FirstOrDefault();
                if (largeHerbivore != null)
                {
                    wagon.AddAnimal(largeHerbivore);
                    MediumHerbivores.Remove(largeHerbivore);
                }

                wagons.Add(wagon);
            }
        };

        Wagon wagon1 = new Wagon();
        for (int i = 0; i < LargeHerbivores.Count; i++)
        {
            var largeHerbivore = LargeHerbivores[i];
            if (wagon1.PointsLeft > 4)
            {
                wagon1.AddAnimal(largeHerbivore);
                LargeHerbivores.Remove(largeHerbivore);
                continue;
            }

            foreach (var mediumHerbivore in MediumHerbivores)
            {
                if (wagon1.PointsLeft > 2)
                {
                    wagon1.AddAnimal(mediumHerbivore);
                    LargeHerbivores.Remove(mediumHerbivore);
                    continue;
                }

                foreach (var smallHerbivore in SmallHerbivores)
                {
                    if (wagon1.PointsLeft > 0)
                    {
                        wagon1.AddAnimal(largeHerbivore);
                        LargeHerbivores.Remove(largeHerbivore);
                        continue;
                    }
                }
            }
            
            wagon1 = new Wagon();
            wagon1.AddAnimal(largeHerbivore);
            LargeHerbivores.Remove(largeHerbivore);
        }

        return wagons;
    }
    
}