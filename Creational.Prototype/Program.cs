using System;

namespace Creational.Prototype {
    class Program {
        static void Main(string[] args) {
            CloneFactory animalMaker = new CloneFactory();

            Sheep sally = new Sheep();
            Sheep cloneSheep = (Sheep)animalMaker.getClone(sally);

            Console.WriteLine("Normal Sally : {0} ", sally.GetHashCode());
            Console.WriteLine("Clone  Sally : {0} ", cloneSheep.GetHashCode());

            Console.Read();
        }
    }
}
