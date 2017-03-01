namespace Creational.Prototype {
    public class Sheep : Animal {
        public object Clone() {
            return MemberwiseClone() as Sheep;
        }
    }
}