using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipWinForm
{
    class Ship
    {

        const int CYCLE_WEIGTH = 3;
        const int CAR_WEIGTH = 5;
        const int TRUCK_WEIGTH = 11;
        const int TRAIN_WEIGTH = 17;

        const int MAX_WEIGTH = 10; // for random Capacity generator
        

        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCount { get; set; }

        Random random = new Random();

        public Ship()
        {
            // Constructor - calld when a new instance is created.
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCount = 0;

            // Create a random sized ship.
            Capacity = (CYCLE_WEIGTH * random.Next(MAX_WEIGTH)) +
                        (CAR_WEIGTH * random.Next(MAX_WEIGTH)) +
                        (TRUCK_WEIGTH * random.Next(MAX_WEIGTH)) +
                        (TRAIN_WEIGTH * random.Next(MAX_WEIGTH));
        }

        public int GetShipLoad()
        {
            // Calculate total weight of the cargo.
            return (CycleCount * CYCLE_WEIGTH) + (CarCount * CAR_WEIGTH) + (TruckCount * TRUCK_WEIGTH) + (TrainCount * TRAIN_WEIGTH);
        }

        public int OverUnder()
        {
            // Return a value of how loaded the ship is.
            return Capacity - GetShipLoad();
        }

        public override string ToString()
        {
            return $"Capacity = {Capacity}, CurrentLoad = {GetShipLoad()}";
        }
    }
}
