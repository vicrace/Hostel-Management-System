using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment_Defaultt
{
    public partial class Modify_Information : Form
    {
        private DataTable studentTable = new DataTable();//declare student table for student data grid view
        private DataTable hostelTable = new DataTable();//declare hostel table for hostel data grid view
        private int indexRow;//declare index to access the row index of selected row in data grid view
        public Modify_Information()
        {
            InitializeComponent();
        }

        private void Modify_Information_FormClosing(object sender, FormClosingEventArgs e)//call ClosingForm method from Main Form to save all text files.
        {
            Main.ClosingForm();
        }
        
        private void Modify_Information_Load(object sender, EventArgs e)
        {
            studentTable.Columns.Add("Name", typeof(string));//declare column name for student data grid view
            studentTable.Columns.Add("Id", typeof(string));
            studentTable.Columns.Add("StudySem", typeof(string));
            studentTable.Columns.Add("HostelRoom", typeof(int));
            studentTable.Columns.Add("HostelFloor", typeof(int));

            dgvStudentList.DataSource = studentTable;

            Student[] students = Admin.book.SearchStudentInfo(tbxStudentSearch.Text, "ALL");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    studentTable.Rows.Add(students[i].Name, students[i].Id, students[i].StudySemester, students[i].HostelRoom, students[i].HostelFloor);//add column name into the data grid view
                }
            }

            dgvStudentList.DataSource = studentTable;



            hostelTable.Columns.Add("RoomNum", typeof(int));//declare column name for hostel data grid view
            hostelTable.Columns.Add("RoomOccupant", typeof(string));
            hostelTable.Columns.Add("RoomStatus", typeof(bool));
            

            Hostel[] hostel = Admin.book.SearchHostelInfo(0, "ALL");
            for (int j = 0; j < hostel.Length; j++)
            {
                if (hostel[j] != null)
                {
                    hostelTable.Rows.Add(hostel[j].RoomNumber, hostel[j].RoomOccupant, hostel[j].RoomStatus);//add column name in to data grid view
                }
            }
            dgvHostelList.DataSource = hostelTable;



        }

        private void btnStudentModify_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvStudentList.Rows[indexRow];//locate the row index that has been selected
                bool nameResult = Regex.IsMatch(tbxStudentName.Text.Trim(), @"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$");//boolean variable to check if the student name contains alphabet only
                bool idSpaceResult = tbxStudentID.Text.ToString().Contains(" ");//check if the student ID contains spacing
                bool idResult = Regex.IsMatch(tbxStudentID.Text, "^[0-9]*$");//check if the student ID contains only numbers

                if (row == null)
                {
                    throw new NoneSelectionException();
                }

                else if(tbxStudentName.Text == "" ||tbxStudentID.Text == ""||cmbStudentSem.Text == "")
                {
                    throw new NullException();
                }
                else if (!nameResult)
                {
                    throw new LetterOnlyException(tbxStudentName.Text);
                }

                else if (!idResult)
                {
                    if (idSpaceResult && idResult)
                    {
                        throw new SpaceException();
                    }
                    throw new NumberOnlyException(tbxStudentID.Text);
                }

                else if (tbxStudentID.Text.Length >= 8)
                {
                    throw new LengthException("7");
                }

                else
                { 
                    for (int i = 0; i < Admin.book.StudentList.Length; i++)
                    {
                        if (Admin.book.StudentList[i] != null && tbxStudentID.Text == Admin.book.StudentList[i].Id &&tbxStudentName.Text == Admin.book.StudentList[i].Name)
                        {
                            throw new DuplicationException(string.Format(" Student ID - {0}", tbxStudentID.Text));
                        }
                    }
                
                    Student selectedStudent = new Student(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), Convert.ToInt32(row.Cells[3].Value.ToString()), Convert.ToInt32(row.Cells[4].Value.ToString()));
                    Admin.book.ModifyStudent(selectedStudent, tbxStudentName.Text, tbxStudentID.Text, cmbStudentSem.Text);
                    UpdateInformation();
                }
            }

            catch (NullException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (LetterOnlyException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (NumberOnlyException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (DuplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (SpaceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch(NoneSelectionException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (LengthException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnHostelModify_Click(object sender, EventArgs e)
        {
            try
            {
                bool idResult = Regex.IsMatch(tbxStudentID.Text, "^[0-9]*$");
                DataGridViewRow row = dgvHostelList.Rows[indexRow];
                if (row == null)
                {
                    throw new NoneSelectionException();
                }

                else if (!idResult)
                {
                    if (tbxStudentID.Text.Any(Char.IsWhiteSpace))
                    {
                        throw new SpaceException();
                    }

                    throw new NumberOnlyException(tbxStudentID.Text);
                }

                else
                {
                    bool result = false;

                    for (int i = 0; i < Admin.book.StudentList.Length; i++)
                    {
                        if (Admin.book.StudentList[i] != null && tbxRoomOccupant.Text == Admin.book.StudentList[i].Id)
                        {
                            result = true;
                            break;
                        }
                        else if (Admin.book.StudentList[i] != null && tbxRoomOccupant.Text == "")
                        {
                            result = true;
                            break;
                        }
                    }

                    if (result != true)
                    {
                        throw new NoneExistException(tbxRoomOccupant.Text);
                    }

                    Hostel selectedHostel = new Hostel(Convert.ToInt32(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), Convert.ToBoolean(row.Cells[2].Value.ToString()));
                    Admin.book.ModifyHostel(selectedHostel, tbxRoomOccupant.Text);
                    UpdateInformation();
                }
            }

            catch(NoneSelectionException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (NumberOnlyException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (SpaceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (NoneExistException ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 

        private void btnHostelSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxHostelSearch.Text == "" && cmbHostelSearch.Text == "ROOM NUM")
                {
                    throw new NoneSearchException();
                }

                else
                {
                    string input = tbxHostelSearch.Text;
                    int roomNo = 0;
                    if (input != "")
                    {
                        roomNo = Convert.ToInt32(input);
                        Hostel[] hostel = Admin.book.SearchHostelInfo(roomNo, cmbHostelSearch.Text);
                        var hostelList = hostel;
                        dgvHostelList.DataSource = hostelList;
                    }

                    else
                    {
                        Hostel[] hostel = Admin.book.SearchHostelInfo(0, cmbHostelSearch.Text);
                        var hostelList = hostel;
                        dgvHostelList.DataSource = hostelList;
                    }

                }
            }

            catch (NoneSearchException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f = new Admin();
            f.Show();
        }

        private void UpdateInformation() //update the data grid views and empty the text boxes
        {
            Student[] students = Admin.book.SearchStudentInfo(tbxStudentSearch.Text, "ALL");
            var studentList = students;
            dgvStudentList.DataSource = studentList;

            Hostel[] hostels = Admin.book.SearchHostelInfo(0, "ALL");
            var hostelList = hostels;
            dgvHostelList.DataSource = hostelList;
            tbxStudentID.Text = string.Empty;
            tbxStudentName.Text = string.Empty;
            cmbStudentSem.Text = string.Empty;
            tbxRoomOccupant.Text = string.Empty;
        }

        private void DgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentList.Rows[indexRow];
            tbxStudentName.Text = row.Cells[0].Value.ToString();
            tbxStudentID.Text = row.Cells[1].Value.ToString();
            cmbStudentSem.Text = row.Cells[2].Value.ToString();

        }

        private void DgvHostelList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvHostelList.Rows[indexRow];
            tbxRoomOccupant.Text = row.Cells[1].Value.ToString();
        }

        private void BtnStudentSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxStudentSearch.Text == "" && cmbStudentSearch.Text != "ALL")
                {
                    throw new NoneSearchException();
                }

                else
                {
                    Student[] students = Admin.book.SearchStudentInfo(tbxStudentSearch.Text, cmbStudentSearch.Text);
                    var studentList = students;
                    dgvStudentList.DataSource = studentList;
                }
            }

            catch (NoneSearchException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
