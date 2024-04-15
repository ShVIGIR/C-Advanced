

namespace Class06.Exercises.Entites
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public double MilesPerGalon { get; set; }
        public int Cylinders { get; set; }
        public double HorsePower { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// Acceleration time to 100kmph
        /// </summary>
        public double AccelerationTime { get; set; }
        public string Origin { get; set; }

        public override string GetInfo()
        {
            return $"Model: {Model} - [{Origin}], MilesPerGalon: {MilesPerGalon}, AccelerationTime: {AccelerationTime}, Cylinders: {Cylinders}, HorsePower: {HorsePower}, Weight: {Weight}";
        }
    }
}
