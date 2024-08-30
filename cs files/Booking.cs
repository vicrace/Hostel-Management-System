using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Defaultt
{
    public class Booking

    {
        private static readonly int ROOM_MAX = 8;
        private static readonly int FLOOR_MAX = 4;
        private static readonly int OCCUPANT_MAX = 32;
        private static readonly int HOSTEL_REGISTRATION_MAX = 200;// the maximum registration application for the system that we can accept is 200


        private int numberOfHostelRoomList;
        public int NumberOfHostelRoomList
        {
            get { return numberOfHostelRoomList; }
        }

        private int numberOfStudentList;
        public int NumberOfStudentList
        {
            get { return numberOfStudentList; }
            set { numberOfStudentList = value; }
        }

        private int numberOfBooking;
        public int NumberOfBooking
        {
            get { return numberOfBooking; }
            set { numberOfBooking = value; }
        }

        private Student[] studentList;
        public Student[] StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        private Hostel[,] hostelRoomList;
        public Hostel[,] HostelRoomList
        {
            get { return hostelRoomList; }
            set { hostelRoomList = value; }
        }

        public Booking()//initialise all number with 0 (number of student, number of occupant in hostel, number of booking)
        {
            numberOfStudentList = 0;
            studentList = new Student[HOSTEL_REGISTRATION_MAX];
            numberOfHostelRoomList = 0;
            numberOfBooking = 0;
            hostelRoomList = new Hostel[FLOOR_MAX, ROOM_MAX];
        }

        public void ModifyStudent(Student student, string newName, string newId, string newSemester)
        {
            for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
            {


                if (studentList[i] != null && studentList[i].Id == student.Id)
                {
                    if (newName != "")
                    {
                        studentList[i].Name = newName;

                    }
                    if (newId != "")
                    {
                        studentList[i].Id = newId;

                        string roomNo = studentList[i].HostelFloor + "0" + studentList[i].HostelRoom;

                        for(int j = 0; j < FLOOR_MAX; j++)
                        {
                            for(int k = 0; k < ROOM_MAX; k++)
                            {
                                if(hostelRoomList[j, k] != null && hostelRoomList[j, k].RoomNumber == Convert.ToInt32(roomNo))
                                {
                                    hostelRoomList[j, k].RoomOccupant = newId;
                                    break;
                                }
                            }
                        }
                    }
                    if (newSemester != "")
                    {
                        studentList[i].StudySemester = newSemester;
                    }

                }
            }
        } // to change the student record

        public void ModifyHostel(Hostel hostel, string newOccupant) // 3 condition
        {
            int Floor = hostel.RoomNumber / 100;
            int Room = hostel.RoomNumber % (Floor * 100);

            for(int j = 0; j < FLOOR_MAX; j++)
            {
                for(int k = 0; k < ROOM_MAX; k++)
                {
                    if(hostelRoomList[j,k] != null && hostelRoomList[j,k].RoomNumber == hostel.RoomNumber)
                    {
                        if(newOccupant !="" && hostel.RoomOccupant != null) // condition 1 ( new student replace old student)
                        {

                            for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
                            {
                                if (studentList[i] != null && studentList[i].Id == hostel.RoomOccupant)
                                {     
                                    studentList[i].HostelRoom = 0;
                                    studentList[i].HostelFloor = 0;
                                }
                                if (studentList[i] != null && studentList[i].Id == newOccupant)
                                {
                                    studentList[i].HostelFloor = Floor;
                                    studentList[i].HostelRoom = Room;
                                }
                            }

                            HostelRoomList[j, k].RoomOccupant = newOccupant;
                            HostelRoomList[j, k].RoomStatus = true;
                            break;
                        }
                        else if(newOccupant != "" && hostel.RoomOccupant == null) // condition 2 (new student move in new hostel room)
                        {
                            for(int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
                            {
                                if(studentList[i] != null && studentList[i].Id == newOccupant)
                                {
                                    studentList[i].HostelFloor = Floor;
                                    studentList[i].HostelRoom = Room;
                                    break;
                                }
                            }
                            HostelRoomList[j, k].RoomOccupant = newOccupant;
                            HostelRoomList[j, k].RoomStatus = true;
                            break;
                        }
                        else if (newOccupant == "") //condition 3 (clear a hostel room occupant)
                        {
                            for(int i = 0; i < HOSTEL_REGISTRATION_MAX; i ++)
                            {
                                if(studentList[i] != null && studentList[i].Id == hostel.RoomOccupant)
                                {
                                    studentList[i].HostelFloor = 0;
                                    studentList[i].HostelRoom = 0;
                                    break;
                                }
                            }

                            HostelRoomList[j, k].RoomOccupant = null;
                            HostelRoomList[j, k].RoomStatus = false;
                            break;
                        }
                    }
                }
            }
        }

        public void AddInfo(Student student, Hostel hostel)
        {

            int floorNo = hostel.RoomNumber / 100;
            int roomNo = hostel.RoomNumber % (100 * floorNo);
            for (int i = 0; i < FLOOR_MAX; i++)
            {
                if (floorNo - 1 == i)
                {
                    for (int j = 0; j < ROOM_MAX; j++)
                    {


                        if (roomNo - 1 == j && hostel.RoomStatus == false && hostel.RoomOccupant == null)
                        {

                            if (numberOfBooking <= OCCUPANT_MAX)
                            {

                                hostel.RoomStatus = true;
                                hostel.RoomOccupant = student.Id;
                                hostelRoomList[i, j] = hostel;

                            }
                        }

                    }

                }
            }

            numberOfBooking++;

            for (int k = 0; k < HOSTEL_REGISTRATION_MAX; k++)
            {
                if (studentList[k] != null && student.Id == studentList[k].Id)
                {
                    studentList[k].HostelFloor = floorNo;
                    studentList[k].HostelRoom = roomNo;
                }
            }

        } // for booking purpose (assign the student id into hostel object , at the same time assign the room and floor no into student object.

        public void AddInfo(Student student)
        {
            Student s = new Student(student.Name.ToUpper(), student.Id, student.StudySemester.ToUpper(), 0, 0);

            for(int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
            {
                if (numberOfStudentList < HOSTEL_REGISTRATION_MAX && studentList[i] == null)
                {
                    studentList[i] = s;
                    numberOfStudentList++;
                    break;
                }
            } 
        } // create a student

        

        public Student[] SearchStudentInfo(string search, string parameter)
        {
            Student[] students = new Student[HOSTEL_REGISTRATION_MAX];
            int index = 0;

            if (parameter == "ID")
            {
                for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
                {
                    if (studentList[i] != null && studentList[i].Id.Contains(search))
                    {
                        students[index] = studentList[i];
                        index++;
                    }

                }
            }
            else if (parameter == "SEMESTER")
            {
                for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
                {
                    if (studentList[i] != null && studentList[i].StudySemester.Contains(search.ToUpper()))
                    {
                        students[index] = studentList[i];
                        index++;
                    }


                }
            }
            else if (parameter == "NAME")
            {
                for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
                {

                    if (studentList[i] != null && studentList[i].Name.Contains(search.ToUpper()))
                    {
                        students[index] = studentList[i];
                        index++;
                    }
                }
            }
            else if (parameter == "ROOM")
            {
                for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
                {
                    int convert = Convert.ToInt32(search);

                    if (studentList[i] != null && convert == studentList[i].HostelRoom)
                    {
                        students[index] = studentList[i];
                        index++;
                    }

                }
            }
            else if (parameter == "FLOOR")
            {
                for (int i = 0; i < FLOOR_MAX; i++)
                {
                    int convert = Convert.ToInt32(search);
                    if (studentList[i] != null && convert == studentList[i].HostelFloor)
                    {
                        students[index] = studentList[i];
                        index++;
                    }

                }
            }
            else if (parameter == "ALL")
            {
                for (int i = 0; i < studentList.Length; i++)
                {
                    if (studentList[i] != null)
                    {
                        students[index] = studentList[i];
                        index++;
                    }
                }
            }

            return students;

        } // use to search student record, with few parameters in the combo box which determine the search field.
        
        public Hostel[] SearchHostelInfo(int hostelNumber, string parameter)
        {
            Hostel[] hostel = new Hostel[OCCUPANT_MAX];
            int index = 0;
            if (parameter == "ALL")
            {
                for (int i = 0; i < FLOOR_MAX; i++)
                {
                    for (int j = 0; j < ROOM_MAX; j++)
                    {
                        if (hostelRoomList[i, j] != null)
                        {
                            hostel[index] = hostelRoomList[i, j];
                            index++;
                        }
                    }
                }
            }
            else if (parameter == "VACANT")
            {
                for (int i = 0; i < FLOOR_MAX; i++)
                {
                    for (int j = 0; j < ROOM_MAX; j++)
                    {
                        if (hostelRoomList[i, j] != null && hostelRoomList[i, j].RoomStatus == false)
                        {
                            hostel[index] = hostelRoomList[i, j];
                            index++;
                        }
                    }
                }
            }
            else if (parameter == "OCCUPIED")
            {
                for (int i = 0; i < FLOOR_MAX; i++)
                {
                    for (int j = 0; j < ROOM_MAX; j++)
                    {
                        if (hostelRoomList[i, j] != null && hostelRoomList[i, j].RoomStatus == true)
                        {
                            hostel[index] = hostelRoomList[i, j];
                            index++;
                        }
                    }
                }
            }
            else if (parameter == "ROOM NUM")
            {
                for (int i = 0; i < FLOOR_MAX; i++)
                {
                    for (int j = 0; j < ROOM_MAX; j++)
                    {
                        if (hostelRoomList[i, j] != null && hostelNumber == hostelRoomList[i, j].RoomNumber)
                        {
                            hostel[index] = hostelRoomList[i, j];
                            break;
                        }
                    }
                }
            }


            return hostel;
        } // use to search hostel record, with few parameters in the combo box which determine the search field.

        public void DeleteBookings(Hostel hostel)
        {

            for (int k = 0; k < HOSTEL_REGISTRATION_MAX; k++)
            {
                if (studentList[k] != null && studentList[k].Id == hostel.RoomOccupant)
                {
                    studentList[k].HostelFloor = 0;
                    studentList[k].HostelRoom = 0;
                    numberOfBooking--;
                    break;
                }
            }

            for (int i = 0; i < FLOOR_MAX; i++)
            {
                for (int j = 0; j < ROOM_MAX; j++)
                {
                    if (hostelRoomList[i, j] != null && hostelRoomList[i, j].RoomNumber == hostel.RoomNumber)
                    {
                        hostelRoomList[i, j].RoomOccupant = null;
                        hostelRoomList[i, j].RoomStatus = false;
                        break;
                    }
                }
            }
        } // delete one booking record

        public void DeleteAllBookings()
        {
            for (int i = 0; i < FLOOR_MAX; i++)
            {
                for (int j = 0; j < ROOM_MAX; j++)
                {
                    if (hostelRoomList[i, j] != null)
                    {
                        hostelRoomList[i, j].RoomOccupant = null;
                        hostelRoomList[i, j].RoomStatus = false;
                        numberOfBooking--;
                    }


                }
            }

            for (int k = 0; k < HOSTEL_REGISTRATION_MAX; k++)
            {
                if (studentList[k] != null)
                {
                    studentList[k].HostelFloor = 0;
                    studentList[k].HostelRoom = 0;
                }

            }
        } // delete all booking record

        public void DeleteStudent(Student student)
        {
            for (int j = 0; j < FLOOR_MAX; j++)
            {
                for (int k = 0; k < ROOM_MAX; k++)
                {
                    if (hostelRoomList[j, k] != null && hostelRoomList[j, k].RoomOccupant == student.Id)
                    {
                        hostelRoomList[j, k].RoomOccupant = null;
                        hostelRoomList[j, k].RoomStatus = false;
                        numberOfBooking--;
                    }
                }
            }

            for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
            {
                if (studentList[i] != null && studentList[i].Id == student.Id)
                {
                    studentList[i] = null;
                    numberOfStudentList--;
                }
            }


        } // delete one student record (include the corresponding hostel record)

        public void DeleteAllStudent() //delete all student record
        {
            for (int i = 0; i < HOSTEL_REGISTRATION_MAX; i++)
            {
                if (studentList[i] != null)
                {
                    studentList[i] = null;
                    numberOfStudentList--;
                }
                
            }

            for (int j = 0; j < FLOOR_MAX; j++)
            {
                for (int k = 0; k < ROOM_MAX; k++)
                {
                    if (hostelRoomList[j, k] != null)
                    {
                        hostelRoomList[j, k].RoomOccupant = null;
                        hostelRoomList[j, k].RoomStatus = false;
                        numberOfBooking--;
                    }
                }
            }
        } 

    }
}
