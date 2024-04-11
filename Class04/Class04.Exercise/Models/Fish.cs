
using Class04.Exercise.Models.BaseModel;


namespace Class04.Exercise.Models
{
    public class Fish : Pet
    {

        public string Color { get; set; }
        public double Size { get; set; }
        public Fish(string name, string type, int age, string color, double size) : base(name, type, age)
        {
            Size = size;
            Color = color;
        }

        public override string PrintInfo()
        {
            return $"{Type} {Name} is {Color} fish with size of {Size} sm.";
        }
    }
}
