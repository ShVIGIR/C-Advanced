using Class04.Exercise.Models.BaseModel;

namespace Class04.Exercise.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavouriteFood { get; set; }
        public Dog(string name, string type, int age, bool goodboy, string food) : base(name, type, age)
        {
            GoodBoy = goodboy;
            FavouriteFood = food;
        }

        public override string PrintInfo()
        {

            return $" {Type} {Name} [{Age}] is {(GoodBoy ? "good boy" : "not a good boy")}.";

        }
    }
}

