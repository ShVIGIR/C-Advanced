

using Class04.Exercise.Interfaces;
using Class04.Exercise.Models.BaseModel;

namespace Class04.Exercise.Models
{
    public class PetStore<T> : IPetStore where T : Pet
    {


        public List<T> Pets { get; set; }


        public PetStore()
        {
            Pets = new List<T>();
        }
        public void PrintPets()
        {
            if (Pets.Count == 0)
            {
                Console.WriteLine("No pets available in the store.");
                return;
            }
            else
            {
                        Console.WriteLine($"Available pets in store: ");

                for (int i = 0; i < Pets.Count; i++)
                {
                        Console.WriteLine($"{i + 1}) {Pets[i]}");               
                }
            }
        }
        public void BuyPet(string name)
        {
            T pet = Pets.SingleOrDefault(p => p.Name == name);
            if (pet == null)
            {
                Console.WriteLine("The pet was not found");
                return;
            }
            Pets.Remove(pet);
            for (int i = 0; i < Pets.Count; i++)
            {
                Console.WriteLine($"The {Pets[i].GetType().Name} {Pets[i].Name} was bought!");
            }
        }
    }
}  
