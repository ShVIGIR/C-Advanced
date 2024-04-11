

using Class04.Exercise.Models.BaseModel;


namespace Class04.Exercise.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int lives) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = lives;
        }


        public override string PrintInfo()
        {
            return $"{Type} {Name} [{Age}] is {(Lazy ? "lazy" : "not lazy")} cat with {LivesLeft} lives left.";
        }
    }
}

