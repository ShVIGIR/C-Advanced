

using Class02.Task1.Entities.Interfaces;

namespace Class02.Task1.Entities.Models.BaseModel
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public User(int id, string name, string userName)
        {
            Id = id;
            Name = name;
            UserName = userName;
        }
        public string PrintInfo()
        {
            return $"{Name} , ID: {Id}, username: {UserName}";
        }
        public abstract string PrintUser();

    

       
    }
}