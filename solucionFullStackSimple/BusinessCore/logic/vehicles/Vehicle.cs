using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCore.logic.vehicles
{

    class Vehicle
    {
        public Guid ID { get; }
        public float Last_Longitude { get; set; }
        public float Last_Latitude { get; set; }
        public int Batery { get; set; }
        public DateTime Last_CheckIn { get; set; }
        public bool In_use { get; set; }
        public string Vehicle_type { get; set; }

        public Vehicle (Guid pID)
        {
            ID = pID;
        }
        public Vehicle(Guid pID, string pVehicle_type)
        {
            ID = pID;
            Vehicle_type = pVehicle_type;
        }
    }
}
