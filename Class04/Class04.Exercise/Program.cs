

using Class04.Exercise.Models;
using Class04.Exercise.Models.BaseModel;

PetStore<Dog> dogStore = new PetStore<Dog>();
PetStore<Cat> catStore = new PetStore<Cat>();
PetStore<Fish> fishStore = new PetStore<Fish>();


Dog dog1 = new Dog("Carli", "dog", 2, true, "bones");
Dog dog2 = new Dog("Majlo", "dog", 1, false, "milk");
Cat cat1 = new Cat("Bejbi", "cat", 5, false, 4);
Cat cat2 = new Cat("Riki", "cat", 2, true, 9);
Fish fish1 = new Fish("Nemo", "fish", 1, "orange", 0.5);
Fish fish2 = new Fish("Lina", "fish", 3, "gold", 1);


dogStore.Pets.Add(dog1);
dogStore.Pets.Add(dog2);
catStore.Pets.Add(cat1);
catStore.Pets.Add(cat2);
fishStore.Pets.Add(fish1);
fishStore.Pets.Add(fish2);


List<Pet> allStores = new();


catStore.BuyPet(cat1.Name);
dogStore.BuyPet(dog2.Name);
catStore.PrintPets();
dogStore.PrintPets();
fishStore.PrintPets();

/*allStores.AddRange(dogStore.Pets);
allStores.AddRange(catStore.Pets);
allStores.AddRange(fishStore.Pets);
*/