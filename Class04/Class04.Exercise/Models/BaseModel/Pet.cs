

namespace Class04.Exercise.Models.BaseModel
{
        public abstract class Pet 
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }
            public Pet(string name, string type, int age)
            {
                Name = name;
                Type = type;
                Age = age;
            }
            public abstract string PrintInfo();
            public override string ToString() //ova go iskopav i ne mi e jasno
            {
                return PrintInfo();
            }
        }
    }

