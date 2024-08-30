using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Defaultt
{
    public class Hostel
    {
        private int roomNumber; // to store room number, Naming: room 1 floor 1--->101
        public int RoomNumber
        {
            get { return roomNumber; }
            set
            {
                if (value >= 100 && value <= 108)
                    roomNumber = value;
                if (value >= 200 && value <= 208)
                    roomNumber = value;
                if (value >= 300 && value <= 308)
                    roomNumber = value;
                if (value >= 400 && value <= 408)
                    roomNumber = value;
            }
        }

        private string roomOccupant; // who live in this room . record the student id
        public string RoomOccupant
        {
            get { return roomOccupant; }
            set { roomOccupant = value; }
        }

        private bool roomStatus; // bool type to see if the room is occupied or vacant
        public bool RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        public Hostel(int aRoomNumber)//initialise unoccupied room 
        {
            RoomNumber = aRoomNumber;
            RoomOccupant = null;
            RoomStatus = false;
        }

        public Hostel(int roomNumber, string occupant, bool status)//initialise occupied room with student ID inside
        {
            RoomNumber = roomNumber;
            RoomOccupant = occupant;
            roomStatus = status;
        }
    }
}
