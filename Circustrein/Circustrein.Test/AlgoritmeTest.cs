using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein.Context;
using Circustrein.Interfaces;
using System;

namespace Circustrein.Test
{
    [TestClass]
    public class AlgoritmeTest
    {

        IAlgoritme context;
        Wagon TestWagon = new Wagon();
        Animal TestAnimal;
        Wagon TestWagonFaulty = new Wagon();
        Animal TestAnimalFaulty;

        [TestInitialize]
        public void SetUpTests()
        {
            context = new AlgoritmeTestContext();

            TestWagon.Animals.Add(new Animal(size: AnimalSize.Medium, eater: AnimalType.Carnivore, points: (int)AnimalSize.Medium));
            TestWagon.Animals.Add(new Animal(size: AnimalSize.Large, eater: AnimalType.Herbivore, points: (int)AnimalSize.Large));
            TestWagon.FreePoints = 2;
            TestAnimal = new Animal(AnimalSize.Small, AnimalType.Herbivore, (int)AnimalSize.Small);

            TestWagonFaulty.Animals.Add(new Animal(size: AnimalSize.Medium, eater: AnimalType.Herbivore, points: (int)AnimalSize.Medium));
            TestWagonFaulty.Animals.Add(new Animal(size: AnimalSize.Large, eater: AnimalType.Herbivore, points: (int)AnimalSize.Large));
            TestWagonFaulty.FreePoints = 2;

            TestAnimalFaulty = new Animal(AnimalSize.Large, AnimalType.Carnivore, (int)AnimalSize.Large);

        }

        [TestMethod]
        public void AnimalToAddIsSmallestTest()
        {
            bool TestBool = context.AnimalToAddIsSmallest(TestWagon, TestAnimal);

            Assert.IsTrue(TestBool);
        }

        [TestMethod]
        public void AnimalToAddIsSmallestTestFail()
        {
            bool TestBool = context.AnimalToAddIsSmallest(TestWagonFaulty, TestAnimalFaulty);

            Assert.IsFalse(TestBool);
        }

        [TestMethod]
        public void WagonHasMeatEaterTest()
        {
            bool TestBool = context.WagonHasMeatEater(TestWagon);

            Assert.IsTrue(TestBool);
        }

        [TestMethod]
        public void WagonHasMeatEaterTestFail()
        {
            bool TestBool = context.WagonHasMeatEater(TestWagonFaulty);

            Assert.IsFalse(TestBool);
        }

        [TestMethod]
        public void WagonHasRoomTest()
        {
            bool TestBool = context.WagonHasRoom(TestWagon, TestAnimal);

            Assert.IsTrue(TestBool);
        }

        [TestMethod]
        public void WagonHasRoomTestFail()
        {
            bool TestBool = context.WagonHasRoom(TestWagonFaulty, TestAnimalFaulty);

            Assert.IsFalse(TestBool);
        }

        [TestMethod]
        public void WagonMeatEaterTest()
        {
            Animal TestAnimal = context.WagonMeatEater(TestWagon);

            Assert.AreEqual(TestAnimal.Eater, AnimalType.Carnivore);
        }

        [TestMethod]
        public void WagonMeatEaterTestFail()
        {
            Animal TestAnimal = context.WagonMeatEater(TestWagon);

            Assert.AreNotEqual(TestAnimal, AnimalType.Carnivore);
        }
    }
}
