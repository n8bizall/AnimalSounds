using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            // create animals and only animals that make sounds
            //create classes for animals
            //want to put animals in collection and print a line
            // The animal __ makes the sound __

            Dog dog = new Dog();
            Monkey monkey = new Monkey();
            Cat cat = new Cat();
            Fish fish = new Fish();
            Bird bird = new Bird();
            Snake snake = new Snake();
            Chicken chicken = new Chicken();
            Pig pig = new Pig();
            Tiger tiger = new Tiger();


            IAnimalSounds[] animals = {dog, monkey, cat, fish, bird, snake, chicken, pig, tiger };

            foreach(IAnimalSounds animal in animals){
                string animalName = animal.GetAnimalName();
                string animalSound = animal.GetAnimalSound();
                string message = $"A {animalName}  says {animalSound}.";

                Console.WriteLine(message);

            }
            Console.ReadKey();


        }
    }
}
