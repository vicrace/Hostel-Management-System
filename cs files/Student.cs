using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Defaultt
{
    public class Student
    {

        private string name;
        public string Name//to store student name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;
        public string Id//store student registration number
        {
            get { return id; }
            set { id = value; }
        }

        private string studySemester;//to store current study semester of student, only 2 semester per year
        public string StudySemester
        {
            get { return studySemester; }
            set
            {
                if (value == "Y1S1" || value == "y1s1")
                    studySemester = value;
                if (value == "Y1S2" || value == "y1s2")
                    studySemester = value;
                if (value == "Y2S1" || value == "y2s1")
                    studySemester = value;
                if (value == "Y2S2" || value == "y2s2")
                    studySemester = value;
                if (value == "Y3S1" || value == "y3s1")
                    studySemester = value;
                if (value == "Y3S2" || value == "y3s2")
                    studySemester = value;
            }
        }

        private int hostelRoom; // to store which room the student live ( 1 integer only )
        public int HostelRoom
        {
            get { return hostelRoom; }
            set
            {
                if (value >= 0 && value <= 8)
                    hostelRoom = value;
            }
        }

        private int hostelFloor; // store which floor the student live (1 integer only)
        public int HostelFloor
        {
            get { return hostelFloor; }
            set
            {
                if (value >= 0 && value <= 4)
                    hostelFloor = value;
            }
        }

        public Student(string aName, string aId, string aStudySemester, int aHostelFloor, int aHostelRoom)//initialise student information after a hostel room is assigned to student
        {
            Name = aName;
            Id = aId;
            StudySemester = aStudySemester;
            HostelFloor = aHostelFloor;
            HostelRoom = aHostelRoom;
        }
    }
}
