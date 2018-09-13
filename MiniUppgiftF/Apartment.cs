using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUppgiftF
{
    public class Apartment
    {
        int numberOfRooms;
        bool status;

        public Apartment(int numberOfRooms,bool status)
        {
            this.numberOfRooms = numberOfRooms;
            this.status = status;
        }

        public int NumberOfRooms { get => numberOfRooms;}
        public bool Status { get => status;}

        public void ChangeStatus()
        {
            status = !status;
        }

        public override string ToString()
        {
            return $"{numberOfRooms} {(Status ? "Occupied" : "Empty")}";
        }
    }
}
