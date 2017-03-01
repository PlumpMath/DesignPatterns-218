using System;

namespace Creational.Prototype {
    public class CloneFactory {
        public Animal getClone(Animal animalSample) {
            return animalSample.Clone() as Animal;
        }
    }
}
