using Circustrein.Context;
using Circustrein.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class FCircusTrein : Form
    {

        //Properties
        public List<Animal> animals = new List<Animal>();
        public AlgoritmeContext algoritme = new AlgoritmeContext();

        //Constructor
        public FCircusTrein()
        {
            InitializeComponent();
            CBAnimalSize.DataSource = Enum.GetValues(typeof(AnimalSize));
            CBanimalType.DataSource = Enum.GetValues(typeof(AnimalType));
        }

        //Takes the info and puts it into a list of animals. After that, it adds the data to a ListView.
        private void BAddAnimal_Click(object sender, EventArgs e)
        {

            AnimalSize size = (AnimalSize)Enum.Parse(typeof(AnimalSize), CBAnimalSize.SelectedValue.ToString());
            AnimalType foodtype = (AnimalType)Enum.Parse(typeof(AnimalType), CBanimalType.SelectedValue.ToString());
            int points = (int)size;

            //Create animal
            Animal a = new Animal(size, foodtype, points);
            animals.Add(a);

            //Add animal to table
            var item = new ListViewItem(new[] { CBAnimalSize.SelectedValue.ToString(), CBanimalType.SelectedValue.ToString(), points.ToString() });
            LVanimals.Items.Add(item);
            LVanimals.Visible = true;
        }

        private void BInsertAnimals_Click(object sender, EventArgs e)
        {

        }


        private void BAlgorithm_Click(object sender, EventArgs e)
        {
            Train t = PerformAlghoritm(animals);
            for(int x = 0; x < t.wagons.Count(); x++)
            {
                var item = new ListViewItem(new[] { (x + 1).ToString() , t.wagons[x].Animals.Count().ToString(), (10 - t.wagons[x].FreePoints).ToString()});
                TrainListView.Items.Add(item);
            }
            TrainListView.Visible = true;
        }

        public Train PerformAlghoritm(List<Animal> Animals)
        {
            Train train = new Train();
            Wagon wagon = new Wagon();
            train.wagons.Add(wagon);

            foreach (Animal a in Animals)
            {
                bool AnimalHasBeenAdded = false;
                foreach (Wagon w in train.wagons)
                {
                    if (AnimalHasBeenAdded)
                    {
                        break;
                    }
                    //Check if there is room in the wagon
                    if (algoritme.WagonHasRoom(w, a))
                    {
                        //if animal is a herbivore
                        if (a.Eater == AnimalType.Herbivore)
                        {
                            //If there is no other carnivore 
                            if (!algoritme.WagonHasMeatEater(w))
                            {
                                w.Animals.Add(a);
                                w.FreePoints -= a.points;
                                AnimalHasBeenAdded = true;
                            }


                            //If the carnivore is smaller than the current herbivore animal
                            else if (algoritme.WagonMeatEater(w).Size < a.Size)
                            {
                                w.Animals.Add(a);
                                w.FreePoints -= a.points;
                                AnimalHasBeenAdded = true;
                            }
                        }

                        //Animal is a carnivore
                        else
                        {
                            bool SmallestAnimal = true;
                            //If there is not a bigger carnivore
                            foreach (Animal a2 in w.Animals)
                            {
                                if (a2.Size >= a.Size)
                                {
                                    SmallestAnimal = false;
                                }
                            }

                            //If there are no other meateaters in the wagon and the current animal is the smallest out of the ones in the wagon.
                            if (!algoritme.WagonHasMeatEater(w) && SmallestAnimal)
                            {
                                w.Animals.Add(a);
                                w.FreePoints -= a.points;
                                AnimalHasBeenAdded = true;
                            }

                            //PREVIOUS TRY
                            /*//Looks for biggest carnivore, and checking if it is smaller than the biggest herbivore
                            Animal BiggestCarnivore = w.Animals.FirstOrDefault(a2 => a2.Eater != AnimalType.Herbivore);
                            if (BiggestCarnivore != null)
                            {
                                //Er zit een vleeseter/omnivoor in de wagon
                                if (SizeFits(a, BiggestCarnivore) == true)
                                {
                                    //De planteneter past in de wagon
                                    w.Animals.Add(a);
                                    w.FreePoints -= a.points;
                                    AnimalHasBeenAdded = true;
                                }
                            }
                            else
                            {
                                //er zit geen vleeseter/omnivoor in en er is plek.
                                w.Animals.Add(a);
                                w.FreePoints -= a.points;
                                AnimalHasBeenAdded = true;
                            }*/
                        }
                    }
                }

                //Adds animal to a new wagon because animal can't be added to an existing wagon
                if (!AnimalHasBeenAdded)
                {
                    Wagon w = new Wagon();
                    w.Animals.Add(a);
                    w.FreePoints -= a.points;
                    train.wagons.Add(w);
                }

            }

            return train;
        }

    }
}
