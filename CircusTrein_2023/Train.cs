namespace CircusTrein_2023;

public class Train
{
    private List<Wagon> wagons = new List<Wagon>();
    public List<Wagon> Sorter(List<Animal> LargeHerbivores, List<Animal> MediumHerbivores, List<Animal> SmallHerbivores, List<Animal> Carnivores)
    {
        //1. For each carnivore, make 1 wagon and put it in 1 wagon.
        foreach (var carnivore in Carnivores)
        {
            var wagon = new Wagon();
            wagon.TryAddAnimal(carnivore);
            wagons.Add(wagon);
        }
        
        //2. Get all wagons with small carnivores, put as many medium herbivores in each as possible.
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
                                //TODO TryAddAnimal (tryparse) loop through animals, try add 
                                wagon.TryAddAnimal(mediumHerbivore1);
                                MediumHerbivores.Remove(mediumHerbivore1);
                            }
                        }
                        
                        wagons[j] = wagon;
                        break;
                    case 2:
                        for (int i = 0; i < 2; i++)
                        {
                            var mediumHerbivore2 = MediumHerbivores.FirstOrDefault();
                            if (mediumHerbivore2 != null)
                            {
                                wagon.TryAddAnimal(mediumHerbivore2);
                                MediumHerbivores.Remove(mediumHerbivore2);
                            }
                        }

                        wagons[j] = wagon;
                        break;
                    case 1:
                        var mediumHerbivore3 = MediumHerbivores.FirstOrDefault();
                        if (mediumHerbivore3 != null)
                        {
                            wagon.TryAddAnimal(mediumHerbivore3);
                            MediumHerbivores.Remove(mediumHerbivore3);
                        }

                        wagons[j] = wagon;
                        break;
                }
            }
        };

        //3. Get all wagons with medium carnivores, put as many large herbivores in each as possible.
        for (int j = 0; j < wagons.Count; j++)
        {
            var wagon = wagons[j];

            if (wagon.Animals[0].Size == Size.Medium && wagon.Animals[0].Appetite == Appetite.Carnivore && wagon.PointsLeft > 4)
            {
                var largeHerbivore = LargeHerbivores.FirstOrDefault();
                if (largeHerbivore != null)
                {
                    wagon.TryAddAnimal(largeHerbivore);
                    LargeHerbivores.Remove(largeHerbivore);
                }

                wagons[j] = wagon;
            }
        };

        //4. Get all wagons with small carnivores and fill as many as possible with large herbivores.
        for (int j = 0; j < wagons.Count; j++)
        {
            var wagon = wagons[j];

            if (wagon.Animals[0].Size == Size.Small && wagon.Animals[0].Appetite == Appetite.Carnivore && wagon.PointsLeft > 4)
            {
                var largeHerbivore = LargeHerbivores.FirstOrDefault();
                if (largeHerbivore != null)
                {
                    wagon.TryAddAnimal(largeHerbivore);
                    LargeHerbivores.Remove(largeHerbivore);
                }

                wagons[j] = wagon;
            }
        };
        
        for (int i = 0; i < LargeHerbivores.Count; i++)
        {
            //5. Make a wagon. 
            Wagon wagon1 = new Wagon();
            
            //6. check if large herbivore fits, put it in and repeat in same wagon.
            var largeHerbivore = LargeHerbivores[i];
            while (wagon1.PointsLeft > 4)
            {
                wagon1.TryAddAnimal(largeHerbivore);
                LargeHerbivores.Remove(largeHerbivore);
            }

            //7. If not, check if medium herbivore fits. If yes, but it in and repeat same wagon. 
            foreach (var mediumHerbivore in MediumHerbivores)
            {
                while (wagon1.PointsLeft > 2)
                {
                    wagon1.TryAddAnimal(mediumHerbivore);
                    MediumHerbivores.Remove(mediumHerbivore);
                }

                //8. If not, check if small herbivore fits. If yes, but it in and repeat same wagon.
                foreach (var smallHerbivore in SmallHerbivores)
                {
                    while (wagon1.PointsLeft > 0)
                    {
                        wagon1.TryAddAnimal(smallHerbivore);
                        SmallHerbivores.Remove(smallHerbivore);
                    }
                }
            }
            
            wagon1.TryAddAnimal(largeHerbivore);
            LargeHerbivores.Remove(largeHerbivore);
            wagons.Add(wagon1);
            //9. If not, make a wagon. repeat from line 7.
        }

        for (int i = 0; i < MediumHerbivores.Count; i++)
        {
            //5. Make a wagon. 
            Wagon wagon1 = new Wagon();

            //7. If not, check if medium herbivore fits. If yes, but it in and repeat same wagon. 
            foreach (var mediumHerbivore in MediumHerbivores)
            {
                while (wagon1.PointsLeft > 2)
                {
                    wagon1.TryAddAnimal(mediumHerbivore);
                    MediumHerbivores.Remove(mediumHerbivore);
                }

                //8. If not, check if small herbivore fits. If yes, but it in and repeat same wagon.
                foreach (var smallHerbivore in SmallHerbivores)
                {
                    while (wagon1.PointsLeft > 0)
                    {
                        wagon1.TryAddAnimal(smallHerbivore);
                        SmallHerbivores.Remove(smallHerbivore);
                    }
                }
            }
            
            wagons.Add(wagon1);
            //9. If not, make a wagon. repeat from line 7.
        }
        
        for (int i = 0; i < SmallHerbivores.Count; i++)
        {
            //5. Make a wagon. 
            Wagon wagon1 = new Wagon();
            
            //8. If not, check if small herbivore fits. If yes, but it in and repeat same wagon.
            
            foreach (var smallHerbivore in SmallHerbivores)
            {
                while (wagon1.PointsLeft > 0)
                {
                    wagon1.TryAddAnimal(smallHerbivore);
                    SmallHerbivores.Remove(smallHerbivore);
                }
            }
            
            wagons.Add(wagon1);
            //9. If not, make a wagon. repeat from line 7.
        }
        
        return wagons;
    }
    
}